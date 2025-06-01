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
        public Form1()
        {
            InitializeComponent();
            CreateManagers();
            FillComboBox();
        }

        private void FillComboBox()
        {
            VacantionFilterComboBox.Items.Clear();
            VacantionFilterComboBox.Items.Add(new GetSalaries(salaryManager));
            VacantionFilterComboBox.Items.Add(new GetFiveOnTwoSchedule(workScheduleManager));
            VacantionFilterComboBox.Items.Add(new GetTwoOnTwoSchedule(workScheduleManager));
            VacantionFilterComboBox.Items.Add(new GetSixOnOneSchedule(workScheduleManager));
            VacantionFilterComboBox.Items.Add(new GetFourOnThreeSchedule(workScheduleManager));
            VacantionFilterComboBox.Items.Add(new GetAreas(areaManager));
            VacantionFilterComboBox.Items.Add(new GetEmployers(employerManager));
        }

        private void CreateManagers()
        {
            var httpClient = new HHRuHttpClient();
            httpClient.SetCountOfPages((int)CountOfPagesNumericUpDown.Value);
            countOfPages = httpClient.GetCountOfPages();
            salaryManager = new(httpClient);
            workScheduleManager = new(httpClient);
            areaManager = new(httpClient);
            employerManager = new(httpClient);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (VacantionFilterComboBox.SelectedIndex != -1)
            {
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
                catch (Exception ex)
                {
                    OutputListBox.Items.Add($"Ошибка вывода. Текст: {ex.Message}");
                }
            }
        }

        private void CountOfPagesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
