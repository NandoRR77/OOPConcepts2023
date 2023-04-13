using OOPConcepts.Logic;

namespace OOPConcepts.UserImterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Length == 0)
            {
                MessageBox.Show("You must enter a year.", "Error"); //Este método tiene dos parámetros, error y título ventana
                return;
            }

            if (txtMonth.Text.Length == 0)
            {
                MessageBox.Show("You must enter a month.", "Error");
                return;
            }

            if (txtDay.Text.Length == 0)
            {
                MessageBox.Show("You must enter a day.", "Error");
                return;
            }

            try
            {
                int year = Convert.ToInt32(txtYear.Text);
                int month = Convert.ToInt32(txtMonth.Text);
                int day = Convert.ToInt32(txtDay.Text);

                var date = new Date(year, month, day); //crear un nuevo objeto de la clase Date con los parametros para validar lo que ingresa el usuario
                MessageBox.Show($"¡Congratulations, the date {date} is valid!", "Confirm"); //imprimimos el mensaje con el objeto date creado
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error was ocurred {ex.Message}", "Error");
            }

        }
    }
}