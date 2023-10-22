using System;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Assignment_05
{
    public class Assigment_05
    {
        static string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = AssignmentFive; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";
        SqlConnection con = new SqlConnection(connectionString);

        //------------------------Print All Records Of Employee SqlDataReader-----------------------------------

        public void PrintEmployees()
        {
            string allEmployee = "Select * from Employees";
            con.Open();
            SqlCommand cmd = new SqlCommand(allEmployee, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"ID: {dr[0]}   FirstName:  {dr[1]}   LastName: {dr[2]}   Email: {dr[3]}   PrimaryPhoneNumber: {dr[4]}   SecondaryPhoneNumber: {dr[5]}   CreatedBy: {dr[6]}   CreatedOn: {dr[7]}   ModifiedBy: {dr[8]}   ModifiedOn: {dr[9]}");
            }
            con.Close();
        }
        //---------------------------------Insert Record in the Employee using SqlDataReader----------------------------------
        public void InsertEmployees()
        {
            string fName, lName, email, PrimaryPhNo, createdBy;
            string? secPhNo;
            Console.Write("Enter your First Name: ");
            do
            {
                fName = Console.ReadLine();
            } while (fName == "");

            Console.Write("Enter your Last Name: ");
            do
            {
                lName = Console.ReadLine();
            } while (lName == "");

            Console.Write("Enter Your Email: ");
            do
            {
                email = Console.ReadLine();
            } while (email == "");

            Console.Write("Enter Your Primary Phone number: ");
            do
            {
                PrimaryPhNo = Console.ReadLine();
                if (PrimaryPhNo.Length > 11)
                {
                    Console.WriteLine("Length of Primary Phone Number is greater. Try again!");
                }
            } while (PrimaryPhNo == "" || PrimaryPhNo.Length > 11);

            Console.Write("Enter Your Secondary Phone number: ");
            do
            {
                secPhNo = Console.ReadLine();
                if (secPhNo.Length > 11)
                {
                    Console.WriteLine("Length of Secondary Phone Number is greater.Try again!");
                }
            } while (secPhNo.Length > 11);

            Console.Write("Created by: ");
            do
            {
                createdBy = Console.ReadLine();
            } while (createdBy == "");

            Console.Write("Modified by: ");
            string? modifiedBy = Console.ReadLine();
            DateTime createdOn = DateTime.Now;
            DateTime? modifiedOn;

            if (modifiedBy != "")
            {
                modifiedOn = DateTime.Now;

            }
            else
            {
                modifiedOn = null;
            }
            String Insert = $"INSERT INTO EMPLOYEES (FirstName, LastName, Email, PrimaryPhoneNumber,SecondaryPhoneNumber, CreatedBy, CreatedOn,ModifiedBy,ModifiedOn) VALUES ('{fName}', '{lName}', '{email}', '{PrimaryPhNo}', '{secPhNo}','{createdBy}','{createdOn}','{modifiedBy}','{modifiedOn}')";
            con.Open();
            SqlCommand cmd = new SqlCommand(Insert, con);
            int CountInsertedRows = cmd.ExecuteNonQuery();
            if (CountInsertedRows >= 1)
            {
                Console.WriteLine("Record inserted successfully!");
            }
            con.Close();


        }

        //--------------------------------Delete Employee Record using SqlDataReader-----------------------------------
        
        public void DeleteEmployees()
        {
            Console.Write("Enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            
            string deleteEmp = $"delete from Employees where Id='{id}'";
            con.Open();
            SqlCommand cmd = new SqlCommand(deleteEmp, con);
            int deletedRows = cmd.ExecuteNonQuery();
            if (deletedRows >= 1)
            {
                Console.WriteLine("Record has been deleted successfully!");
            }
            con.Close();
        }

        //--------------------------------Search Employee using SqlDataReader--------------------------------------
        
        public void  SearchEmployees()
        {
            Console.Write("Enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());
            String searchEmployee = $"Select * from Employees where ID={id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(searchEmployee, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader[0]}   FirstName: {reader[1]}   LastName: {reader[2]}   Email: {reader[3]}   PrimaryPhoneNumber: {reader[4]}   SecondaryPhoneNumber: {reader[5]}   CreatedBy: {reader[6]}   CreatedOn: {reader[7]}   ModifiedBy: {reader[8]}   ModifiedOn: {reader[9]}");
            }
            con.Close();

        }
        
        //------------------------------Update Empployees using SqlDataReader----------------------------------------
        public void UpdateEmployees()
        {
            int id;
            Console.Write("Enter ID of Employee: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter First name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter Last name: ");
            string lName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Primary Phone number: ");
            string PrimaryPhNo;
            do
            {
                PrimaryPhNo = Console.ReadLine();
                if (PrimaryPhNo.Length > 11)
                {
                    Console.WriteLine("Length of Primary Phone Number is greater.Enter again!");
                }
            } while (PrimaryPhNo.Length > 11);
            Console.Write("Enter Secondary Phone number: ");
            string? secPhNo;
            do
            {
                secPhNo = Console.ReadLine();
                if (secPhNo.Length > 11)
                {
                    Console.WriteLine("Length of Secondary Phone Number.Enter again!");
                }
            } while (secPhNo.Length > 11);
            Console.Write("Created by: ");
            string createdBy = Console.ReadLine();

            Console.Write("Modified by: ");
            string? modifiedBy = Console.ReadLine();
            DateTime createdOn = DateTime.Now;

            con.Open();
            string query;
            int updatedRows = 0;
            if (fName != "")
            {
                query = $"update Employees set FirstName='{fName}' where Id='{id}'";
                SqlCommand cmd = new SqlCommand(query, con);
                updatedRows = cmd.ExecuteNonQuery();
            }
            if (lName != "")
            {
                query = $"update Employees set LastName='{lName}' where Id='{id}'";
                SqlCommand cmd = new SqlCommand(query, con);
                updatedRows = cmd.ExecuteNonQuery();
            }
            if (email != "")
            {
                query = $"update Employees set Email='{email}' where Id='{id}'";
                SqlCommand cmd = new SqlCommand(query, con);
                updatedRows = cmd.ExecuteNonQuery();
            }
            if (PrimaryPhNo != "")
            {
                query = $"update Employees set PrimaryPhoneNumber='{PrimaryPhNo}' where Id='{id}'";
                SqlCommand cmd = new SqlCommand(query, con);
                updatedRows = cmd.ExecuteNonQuery();
            }
            if (secPhNo != "")
            {
                query = $"update Employees set SecondaryPhoneNumber='{secPhNo}' where Id='{id}'";
                SqlCommand cmd = new SqlCommand(query, con);
                updatedRows = cmd.ExecuteNonQuery();
            }
            if (createdBy != "")
            {
                query = $"update Employees set CreatedBy='{createdBy}',CreatedOn='{DateTime.Now}' where Id='{id}'";
                SqlCommand cmd = new SqlCommand(query, con);
                updatedRows = cmd.ExecuteNonQuery();
            }

            if (modifiedBy != "")
            {
                query = $"update Employees set ModifiedBy='{modifiedBy}',ModifiedOn='{DateTime.Now}' where Id='{id}'";
                SqlCommand cmd = new SqlCommand(query, con);
                updatedRows = cmd.ExecuteNonQuery();
            }


            if (updatedRows >= 1)
            {
                Console.WriteLine("Record updated Successfully!");
            }
            else
            {
                Console.WriteLine("Record Updation failed!");
            }

            con.Close();

        }

        //-----------------------------Print Employee using SqlDataAdapter-------------------------------------------

        public void PrintEmployeeSqlAdapter()
        {

            string query = "SELECT * FROM Employees";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Employees");

            DataTable table = dataSet.Tables["Employees"];

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"Id: {row["Id"]}   FirstName: {row["FirstName"]}   LastName: {row["LastName"]}   Email: {row["Email"]}   PrimaryPhoneNumber: {row["PrimaryPhoneNumber"]}   SecondaryPhoneNumber: {row["SecondaryPhoneNumber"]}   CreatedBy: {row["CreatedBy"]}   CreatedOn: {row["CreatedOn"]}   ModifiedBy: {row["ModifiedBy"]}   ModifiedOn: {row["ModifiedOn"]}");
            }
            con.Close();

        }

        //---------------------------------Insert Employee using SqlDataAdapter-------------------------------------
        public void InsertEmployeeSqlAdapter()
        {
            string fName, lName, email, PrimaryPhNo, createdBy;
            string? secPhNo;
            Console.Write("Enter your First Name: ");
            do
            {
                fName = Console.ReadLine();
            } while (fName == "");

            Console.Write("Enter your Last Name: ");
            do
            {
                lName = Console.ReadLine();
            } while (lName == "");

            Console.Write("Enter Your Email: ");
            do
            {
                email = Console.ReadLine();
            } while (email == "");

            Console.Write("Enter Your Primary Phone number: ");
            do
            {
                PrimaryPhNo = Console.ReadLine();
                if (PrimaryPhNo.Length > 11)
                {
                    Console.WriteLine("Length of Primary Phone Number is greater. Try again!");
                }
            } while (PrimaryPhNo == "" || PrimaryPhNo.Length > 11);

            Console.Write("Enter Your Secondary Phone number: ");
            do
            {
                secPhNo = Console.ReadLine();
                if (secPhNo.Length > 11)
                {
                    Console.WriteLine("Length of Secondary Phone Number is greater.Try again!");
                }
            } while (secPhNo.Length > 11);

            Console.Write("Created by: ");
            do
            {
                createdBy = Console.ReadLine();
            } while (createdBy == "");

            Console.Write("Modified by: ");
            string? modifiedBy = Console.ReadLine();
            DateTime createdOn = DateTime.Now;
            DateTime? modifiedOn;

            if (modifiedBy != "")
            {
                modifiedOn = DateTime.Now;

            }
            else
            {
                modifiedOn = null;
            }
            String Insert = $"INSERT INTO EMPLOYEES (FirstName, LastName, Email, PrimaryPhoneNumber,SecondaryPhoneNumber, CreatedBy, CreatedOn,ModifiedBy,ModifiedOn) VALUES (@fName, @lName, @email, @PrimaryPhNo, @secPhNo, @createdBy, @createdOn, @modifiedBy, @modifiedOn)";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(Insert, con);
            adapter.InsertCommand.Parameters.AddWithValue("@FirstName", fName);
            adapter.InsertCommand.Parameters.AddWithValue("@LastName", lName);
            adapter.InsertCommand.Parameters.AddWithValue("@Email", email);
            adapter.InsertCommand.Parameters.AddWithValue("@PrimaryPhoneNumber", PrimaryPhNo);
            adapter.InsertCommand.Parameters.AddWithValue("@SecondartPhoneNumber", secPhNo);
            adapter.InsertCommand.Parameters.AddWithValue("@CreatedBy", createdBy);
            adapter.InsertCommand.Parameters.AddWithValue("@CreatedOn", createdOn);
            adapter.InsertCommand.Parameters.AddWithValue("@ModifiedBy", modifiedBy);
            adapter.InsertCommand.Parameters.AddWithValue("@ModifiedOn", modifiedOn);

            int rowsInserted = adapter.InsertCommand.ExecuteNonQuery();
            if (rowsInserted > 0)
            {
                Console.WriteLine("Record inserted Successfully!");
            }
            else
            {
                Console.WriteLine("Record inserted Failed!");
            }

            con.Close();

        }

        //--------------------------------Delete Employee using SqlDataAdapter--------------------------------------

        public void deleteEmployeeSqlAdapter()
        {
            Console.Write("Enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());
            
            string deleteEmployee = "DELETE FROM Employees WHERE ID = @EmployeeID";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = new SqlCommand(deleteEmployee, con);
            adapter.DeleteCommand.Parameters.AddWithValue("@EmployeeID", id);

            int rowsDeleted = adapter.DeleteCommand.ExecuteNonQuery();
            if (rowsDeleted > 0)
            {
                Console.WriteLine("Record deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Record deletion Failed!");
            }
            con.Close();
        }

        //---------------------------------Search Employee using SqlDataAdapter-----------------------------------------

        public void searchEmployeeSqlAdapter() 
        {
            Console.Write("Enter Emp Id: ");
            int id = int.Parse(Console.ReadLine());

            string search = $"SELECT * FROM Employees WHERE Id = {id}";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(search, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Employees");

            DataTable table = dataSet.Tables["Employees"];

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"Id: {row["Id"]}   FirstName: {row["FirstName"]}   LastName: {row["LastName"]}   Email: {row["Email"]}   PrimaryPhoneNumber: {row["PrimaryPhoneNumber"]}   SecondaryPhoneNumber: {row["SecondaryPhoneNumber"]}   CreatedBy: {row["CreatedBy"]}   CreatedOn: {row["CreatedOn"]}   ModifiedBy: {row["ModifiedBy"]}   ModifiedOn: {row["ModifiedOn"]}");
            }
            con.Close();
        }

        //---------------------------------Update Employee using SqlDataAdapter-------------------------------------------

        public void updateEmployeeSqlAdapter()
        {
            int id;
            Console.Write("Enter ID of Employee: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter First name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter Last name: ");
            string lName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Primary Phone number: ");
            string PrimaryPhNo;
            do
            {
                PrimaryPhNo = Console.ReadLine();
                if (PrimaryPhNo.Length > 11)
                {
                    Console.WriteLine("Length of Primary Phone Number is greater.Enter again!");
                }
            } while (PrimaryPhNo.Length > 11);
            Console.Write("Enter Secondary Phone number: ");
            string? secPhNo;
            do
            {
                secPhNo = Console.ReadLine();
                if (secPhNo.Length > 11)
                {
                    Console.WriteLine("Length of Secondary Phone Number.Enter again!");
                }
            } while (secPhNo.Length > 11);
            Console.Write("Created by: ");
            string createdBy = Console.ReadLine();

            Console.Write("Modified by: ");
            string? modifiedBy = Console.ReadLine();
            DateTime createdOn = DateTime.Now;

            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            string query;
            int rowsUpdated = 0;
            if (fName != "")
            {
                query = $"update Employees set FirstName='{fName}' where Id='{id}'";
                adapter.UpdateCommand = new SqlCommand(query, con);
                adapter.UpdateCommand.Parameters.AddWithValue("@FirstName", fName);
                rowsUpdated = adapter.UpdateCommand.ExecuteNonQuery();
            }
            if (lName != "")
            {
                query = $"update Employees set LastName='{lName}' where Id='{id}'";
                adapter.UpdateCommand = new SqlCommand(query, con);
                adapter.UpdateCommand.Parameters.AddWithValue("@LastName", lName);
                rowsUpdated = adapter.UpdateCommand.ExecuteNonQuery();
            }
            if (email != "")
            {
                query = $"update Employees set Email='{email}' where Id='{id}'";
                adapter.UpdateCommand = new SqlCommand(query, con);
                adapter.UpdateCommand.Parameters.AddWithValue("@Email", email);
                rowsUpdated = adapter.UpdateCommand.ExecuteNonQuery();
            }
            if (PrimaryPhNo != "")
            {
                query = $"update Employees set PrimaryPhoneNumber='{PrimaryPhNo}' where Id='{id}'";
                adapter.UpdateCommand = new SqlCommand(query, con);
                adapter.UpdateCommand.Parameters.AddWithValue("@PrimaryPhoneNumber", PrimaryPhNo);
                rowsUpdated = adapter.UpdateCommand.ExecuteNonQuery();
            }
            if (secPhNo != "")
            {
                query = $"update Employees set SecondaryPhoneNumber='{secPhNo}' where Id='{id}'";
                adapter.UpdateCommand = new SqlCommand(query, con);
                adapter.UpdateCommand.Parameters.AddWithValue("@SecondaryPhoneNumber", secPhNo);
                rowsUpdated = adapter.UpdateCommand.ExecuteNonQuery();
            }
            if (createdBy != "")
            {
                query = $"update Employees set CreatedBy='{createdBy}',CreatedOn='{DateTime.Now}' where Id='{id}'";
                adapter.UpdateCommand = new SqlCommand(query, con);
                adapter.UpdateCommand.Parameters.AddWithValue("@CreatedBy", createdBy);
                adapter.UpdateCommand.Parameters.AddWithValue("@CreatedOn", createdOn);
                rowsUpdated = adapter.UpdateCommand.ExecuteNonQuery();
            }

            if (modifiedBy != "")
            {
                query = $"update Employees set ModifiedBy='{modifiedBy}',ModifiedOn='{DateTime.Now}' where Id='{id}'";
                adapter.UpdateCommand = new SqlCommand(query, con);
                adapter.UpdateCommand.Parameters.AddWithValue("@ModifiedBy", modifiedBy);
                rowsUpdated = adapter.UpdateCommand.ExecuteNonQuery();
            }


            if (rowsUpdated >= 1)
            {
                Console.WriteLine("Record has been updated Successfully!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }

            con.Close();


        }

        // Driver Function

        public static void Main(string[] args)
        {
            Assigment_05 assign=new Assigment_05();
            do
            {
                Console.WriteLine("1. SqlDataReader");
                Console.WriteLine("2. SqlDataAdapter");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    while (true)
                    {

                        Console.WriteLine("Employee Database");
                        Console.WriteLine("1. Print Employees");
                        Console.WriteLine("2. Insert Employee");
                        Console.WriteLine("3. Delete Employee");
                        Console.WriteLine("4. Search Employee");
                        Console.WriteLine("5. Update Employee");
                        Console.WriteLine("6. Exit");


                        Console.Write("Enter your choice: ");
                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                assign.PrintEmployees();
                                break;
                            case 2:
                                assign.InsertEmployees();
                                break;
                            case 3:
                                assign.DeleteEmployees();
                                break;
                            case 4:
                                assign.SearchEmployees();
                                break;
                            case 5:
                                assign.UpdateEmployees();
                                break;
                            case 6:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid coice. Please try again.");
                                break;
                        }

                    }
                }
                else if (selection == 2)
                {
                    while (true)
                    {

                        Console.WriteLine("Employee Database");
                        Console.WriteLine("1. Read Employees");
                        Console.WriteLine("2. Insert Employee");
                        Console.WriteLine("3. Delete Employee");
                        Console.WriteLine("4. Search Employee");
                        Console.WriteLine("5. Update Employee");
                        Console.WriteLine("6. Exit");


                        Console.Write("Enter your choice: ");
                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                assign.PrintEmployeeSqlAdapter();
                                break;
                            case 2:
                                assign.InsertEmployeeSqlAdapter();
                                break;
                            case 3:
                                assign.deleteEmployeeSqlAdapter();
                                break;
                            case 4:
                                assign.searchEmployeeSqlAdapter();
                                break;
                            case 5:
                                assign.updateEmployeeSqlAdapter();
                                break;
                            case 6:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }

                    }
                }
                else if (selection == 3)
                {
                    Environment.Exit(0);
                }
            } while (true);

        }
    }
}
