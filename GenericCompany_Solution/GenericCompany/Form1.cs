using System;
using System.Data;
using System.Data.SqlClient;
namespace GenericCompany

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=LAPTOP-F6NVJ00I\\MSSQLSERVER01;Initial Catalog=Generic_Company_DB;Integrated Security=True;Encrypt=False";
        private string AreTextBoxesFilled(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return "None fields cannot be empty."; // Return a message if any TextBox is empty
                }
            }
            return null; // Return null if all TextBoxes are filled
        }

        // Primero, agregar la clase de conexión
        public class DBConnection
        {
            private static string connectionString = "Data Source=LAPTOP-F6NVJ00I\\MSSQLSERVER01;Initial Catalog=Generic_Company_DB;Integrated Security=True;Encrypt=False"; // Ajusta según tu conexión

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        // Método auxiliar para limpiar los TextBoxes
        private void ClearTextBoxes()
        {
            txtID_employeers.Clear();
            txtName_employeers.Clear();
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
        }

        private object ExceptionHandler(Type dataType, TextBox txtField, string fieldName)
        {
            // Get the content of the TextBox
            string input = txtField.Text;

            // Check if the input is empty
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a value.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null; // Return null to indicate an invalid state
            }

            // Check if the input matches the expected data type
            if (dataType == typeof(int))
            {
                if (!int.TryParse(input, out int result))
                {
                    MessageBox.Show($"Please enter a valid employee {fieldName} ({dataType}).", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null; // Return null if the input is not a valid integer
                }
                return result; // Return the valid integer
            }
            else if (dataType == typeof(string))
            {
                // If data type is string, return the input directly
                return input; // Adjust return type if necessary
            }

            // Handle other data types as needed
            return null; // Return null if the data type is not recognized
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_employeers_Click(object sender, EventArgs e)
        {
            // Verificar si los TextBoxes están llenos
            string result_add_button = AreTextBoxesFilled(txtName_employeers, txtFirstName, txtEmail, txtDepartment);

            if (result_add_button != null)
            {
                MessageBox.Show(result_add_button, "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AddEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros del SP
                        cmd.Parameters.AddWithValue("@Name", txtName_employeers.Text.Trim());
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Department", txtDepartment.Text.Trim());

                        // Parámetro de salida para obtener el ID del nuevo empleado
                        SqlParameter outputParameter = new SqlParameter();
                        outputParameter.ParameterName = "@EmployeeID";
                        outputParameter.SqlDbType = SqlDbType.Int;
                        outputParameter.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParameter);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // Obtener el ID del nuevo empleado
                        int newEmployeeId = Convert.ToInt32(cmd.Parameters["@EmployeeID"].Value);

                        MessageBox.Show($"New employee with ID: {newEmployeeId} has been added.", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Opcional: Limpiar los TextBoxes después de agregar
                        ClearTextBoxes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_employeers_Click(object sender, EventArgs e)
        {
            // Validar si el texto en el TextBox es un número entero
            if (int.TryParse(txtID_employeers.Text, out int employeeId))
            {
                DialogResult result = MessageBox.Show("¿Quieres continuar?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "Data Source=LAPTOP-F6NVJ00I\\MSSQLSERVER01;Initial Catalog=Generic_Company_DB;Integrated Security=True;Encrypt=False";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("deleteEmployeer", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID_Employee", employeeId));
                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected <= 0)
                            {
                                MessageBox.Show("No se encontró ningún empleado con el ID especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("El empleado ha sido eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // El usuario hizo clic en No
                }
            }
            else
            {
                MessageBox.Show("El valor ingresado en el campo 'ID' no es un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtID_employeers_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cancel_employeers_Click(object sender, EventArgs e)
        {
            /* Clear the TextBoxes
            txtID_employeers.Text = string.Empty;
            txtName_employeers.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtSecondName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            */

            ClearTextBoxes();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        // Método opcional para validar el formato del email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Método auxiliar para manejar excepciones SQL específicas
        private string HandleSqlException(SqlException ex)
        {
            return ex.Number switch
            {
                2627 => "A duplicate record already exists.",
                547 => "The update violates database constraints.",
                201 => "Invalid data types in the input fields.",
                _ => $"Database error: {ex.Message}"
            };
        }
        private void button_modify_employeers_Click(object sender, EventArgs e)
        {
            // Validar que el ID sea un número válido
            if (!int.TryParse(txtID_employeers.Text, out int employeeId))
            {
                MessageBox.Show("Por favor ingrese un ID válido.", "ID Inválido",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que los campos requeridos estén llenos
            string result_modify_button = AreTextBoxesFilled(txtName_employeers, txtFirstName, txtSecondName, txtEmail, txtDepartment);
            if (result_modify_button != null)
            {
                MessageBox.Show(result_modify_button, "Campos Requeridos",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ModifyEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                        cmd.Parameters.AddWithValue("@Name", txtName_employeers.Text.Trim());
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("SecondName", txtSecondName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Department", txtDepartment.Text.Trim());

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show($"Empleado con ID: {employeeId} ha sido actualizado.",
                                          "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show($"No se encontró empleado con ID: {employeeId}",
                                          "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el empleado: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}