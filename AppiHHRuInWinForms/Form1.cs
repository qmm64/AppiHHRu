using AppiHHru;
using AppiHHru.Entities.Common.SalaryManagerP;
using AppiHHru.Entities.Common.WorkScheduleManagerP;
using AppiHHRuInWinForms.Entities.IssuanceCommands;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms
{
    public partial class Form1 : Form
    {
        private SalaryManager salaryManager;
        private WorkScheduleManager workScheduleManager;
        public Form1()
        {
            InitializeComponent();
            VacantionFilterComboBox.Items.Add(new GetMinSalary());
            VacantionFilterComboBox.Items.Add(new GetArrangeSalary());
            VacantionFilterComboBox.Items.Add(new GetMaxSalary());
            VacantionFilterComboBox.Items.Add(new GetFiveOnTwoSchedule());
            VacantionFilterComboBox.Items.Add(new GetTwoOnTwoSchedule());
            VacantionFilterComboBox.Items.Add(new GetSixOnOneSchedule());
            VacantionFilterComboBox.Items.Add(new GetFourOnThreeSchedule());

            var httpClient = new HHRuHttpClient();
            salaryManager = new(httpClient);
            workScheduleManager = new(httpClient);

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
                        var result = await ((IssuanceCommands)VacantionFilterComboBox.Items[t]).Execute(salaryManager);
                        BeginInvoke(new Action(() =>
                        {
                            OutputListBox.Items.Add(result);
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
