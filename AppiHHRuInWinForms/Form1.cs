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
        public Form1()
        {
            InitializeComponent();
            var httpClient = new HHRuHttpClient();
            salaryManager = new(httpClient);
            workScheduleManager = new(httpClient);
            areaManager = new(httpClient);
            employerManager = new(httpClient);

            VacantionFilterComboBox.Items.Add(new GetMinSalary(salaryManager));
            VacantionFilterComboBox.Items.Add(new GetArrangeSalary(salaryManager));
            VacantionFilterComboBox.Items.Add(new GetMaxSalary(salaryManager));
            VacantionFilterComboBox.Items.Add(new GetFiveOnTwoSchedule(workScheduleManager));
            VacantionFilterComboBox.Items.Add(new GetTwoOnTwoSchedule(workScheduleManager));
            VacantionFilterComboBox.Items.Add(new GetSixOnOneSchedule(workScheduleManager));
            VacantionFilterComboBox.Items.Add(new GetFourOnThreeSchedule(workScheduleManager));
            VacantionFilterComboBox.Items.Add(new GetAreas(areaManager));
            VacantionFilterComboBox.Items.Add(new GetEmployers(employerManager));
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (VacantionFilterComboBox.SelectedIndex != -1)
            {
                OutputListBox.Items.Clear();    
                try
                {
                    int t = VacantionFilterComboBox.SelectedIndex;
                    Task.Run(async () =>
                    {
                        var result = await ((IssuanceCommands)VacantionFilterComboBox.Items[t]).Execute();
                        BeginInvoke(new Action(() =>
                        {
                            OutputListBox.Items.AddRange(result.ToArray());
                        }));
                    });

                }
                catch (Exception ex)
                {
                    OutputListBox.Items.Add($"Ошибка вывода. Текст: {ex.Message}");
                }
            }
        }
    }
}
