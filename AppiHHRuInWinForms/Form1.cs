using AppiHHRuInWinForms.Entities.Common;
using AppiHHRuInWinForms.Entities.Common.IssuanceCommands;
using AppiHHRuInWinForms.Entities.Common.Responses.AreaManagerP;
using AppiHHRuInWinForms.Entities.Common.Responses.EmployerManagerP;
using AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP;
using AppiHHRuInWinForms.Entities.Common.Responses.WorkScheduleManagerP;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms
{
    public partial class Form1 : Form
    {
        private SalaryManager salaryManager;
        private WorkScheduleManager workScheduleManager;
        private AreaManager areaManager;
        private EmployerManager employerManager;
        private int countOfPages;
        private HHRuHttpClient httpClient;
        public Form1()
        {
            InitializeComponent();
            CreateManagers();
            FillComboBox();
            HardFindStateChange(HardFindCheckBox.Checked);
        }

        private void FillComboBox()
        {
            VacantionFilterComboBox.Items.Clear();
            VacantionFilterComboBox.Items.Add(new GetSalaries(salaryManager));
            VacantionFilterComboBox.Items.Add(new GetWorkDaySchedules(workScheduleManager));
            VacantionFilterComboBox.Items.Add(new GetAreas(areaManager));
            VacantionFilterComboBox.Items.Add(new GetEmployers(employerManager));
            ParamOfFindComboBox.Items.Clear();
            ParamOfFindComboBox.Items.Add(new GetWorkDaySchedules(workScheduleManager));
            ParamOfFindComboBox.Items.Add(new GetAreas(areaManager));
        }

        private void CreateManagers()
        {
            httpClient = new HHRuHttpClient();
            countOfPages = (int)CountOfPagesNumericUpDown.Value;
            httpClient.SetCountOfPages(countOfPages);
            salaryManager = new(httpClient);
            workScheduleManager = new(httpClient);
            areaManager = new(httpClient);
            employerManager = new(httpClient);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (VacantionFilterComboBox.SelectedIndex != -1)
            {
                if (HardFindCheckBox.Checked && ParamOfFindComboBox.SelectedIndex != -1 && ParamComboBox.SelectedIndex!=-1) 
                {

                }
                int selectedIndex = VacantionFilterComboBox.SelectedIndex;
                if (CountOfPagesNumericUpDown.Value != countOfPages)
                {
                    CreateManagers();
                    FillComboBox();
                    VacantionFilterComboBox.SelectedIndex = selectedIndex;
                }
                OutputListBox.Items.Clear();
                try
                {
                    ShowResult();
                }
                catch (Exception ex)
                {
                    OutputListBox.Items.Add($"Ошибка вывода. Текст: {ex.Message}");
                }
            }
        }

        private void ShowResult()
        {
            int t = VacantionFilterComboBox.SelectedIndex;
            Task.Run(async () =>
            {
                var result = await ((IssuanceCommands)VacantionFilterComboBox.Items[t]).Execute();
                BeginInvoke(new Action(() =>
                {
                    if (result == null)
                    {
                        MessageBox.Show("Превышено время ожидания сервера");
                    }
                    else
                    {
                        OutputListBox.Items.AddRange(result.ToArray());
                    }
                }));
            });
        }

        private void HardFindStateChange(bool state)
        {
            panel2.Visible = state;
            if (state)
            {
                panel3.Location = new Point(0, panel2.Location.Y+panel2.Height);
            }
            else
            {
                panel3.Location = panel2.Location;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            HardFindStateChange(HardFindCheckBox.Checked);
        }


        private async Task j()
        {
            var vacanciesResponce = await httpClient.GetAnyVacancies();
            var t = ((ICommandsWithHardFind)ParamOfFindComboBox.SelectedItem).GetParametrs(vacanciesResponce);
            ParamComboBox.Items.Clear();    
            ParamComboBox.Items.AddRange(t.ToArray());
        }
        private void ParamOfFindComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            j();
        }
    }
}
