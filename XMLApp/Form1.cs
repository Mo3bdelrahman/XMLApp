using System;
using System.Xml.Linq;

namespace XMLApp
{
    public partial class Form1 : Form
    {
        XDocument xmlDoc;
        string filePath;
        int currentEmployeeIndex = -1;

        public Form1()
        {
            InitializeComponent();
            UpdateBtnState();
        }

        //Utility
        private TreeNode FillEmployee(XElement employee)
        {
            TreeNode employeeNode = new TreeNode(employee.Element("name").Value);

            // Phones
            TreeNode phonesNode = new TreeNode("Phones");
            foreach (var phone in employee.Descendants("phone"))
            {
                string type = phone.Attribute("type").Value;
                phonesNode.Nodes.Add($"{type}: {phone.Value}");
            }
            employeeNode.Nodes.Add(phonesNode);

            // Addresses
            TreeNode addressesNode = new TreeNode("Addresses");
            foreach (var address in employee.Descendants("address"))
            {
                TreeNode addressNode = new TreeNode("Address");

                string street = address.Element("Street").Value;
                string buildingNumber = address.Element("BuildingNumber").Value;
                string region = address.Element("region").Value;
                string city = address.Element("City").Value;
                string country = address.Element("country").Value;

                addressNode.Nodes.Add($"Street: {street}");
                addressNode.Nodes.Add($"Building Number: {buildingNumber}");
                addressNode.Nodes.Add($"Region: {region}");
                addressNode.Nodes.Add($"City: {city}");
                addressNode.Nodes.Add($"Country: {country}");

                addressesNode.Nodes.Add(addressNode);
            }
            employeeNode.Nodes.Add(addressesNode);

            // Email
            TreeNode emailNode = new TreeNode("Email");
            emailNode.Nodes.Add(employee.Element("email").Value);
            employeeNode.Nodes.Add(emailNode);

            return employeeNode;

        }

        private void LoadAllIntoTreeView()
        {
            allTreeView.Nodes.Clear(); // Clear existing nodes
            if (xmlDoc != null)
            {
                foreach (var employee in xmlDoc.Descendants("employee"))
                {
                    allTreeView.Nodes.Add(FillEmployee(employee));
                }
                totallabel.Text = $"Total = {xmlDoc.Root.Elements("employee").Count()}";
            }
        }
        private void LoadOneIntoTreeView()
        {
            empTreeView.Nodes.Clear();
            XElement searchElement = GetCurrentEmployee();
            empTreeView.Nodes.Add(FillEmployee(searchElement));
            indexlabel.Text = $"Index = {currentEmployeeIndex}";

        }
        private XElement GetCurrentEmployee()
        {
            XElement currentEmployee = xmlDoc.Root.Elements("employee").ElementAt(currentEmployeeIndex);
            return currentEmployee;
        }
        private void ClearForm()
        {
            foreach (Control control in groupBox6.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is GroupBox groupBox)
                {
                    foreach (Control innerControl in groupBox.Controls)
                    {
                        if (innerControl is TextBox innerTextBox)
                        {
                            innerTextBox.Clear();
                        }
                    }
                }
            }
        }
        private void FillForm(XElement employeeElement)
        {
            ClearForm();

            txtName.Text = employeeElement.Element("name")?.Value;
            txtEmail.Text = employeeElement.Element("email")?.Value;

            XElement phonesElement = employeeElement.Element("phones");
            if (phonesElement != null)
            {
                foreach (XElement phoneElement in phonesElement.Elements("phone"))
                {
                    string type = phoneElement.Attribute("type")?.Value;
                    string number = phoneElement.Value;
                    if (type == "home")
                        txtHomePhone.Text = number;
                    else if (type == "work")
                        txtWorkPhone.Text = number;
                }
            }

            XElement addressesElement = employeeElement.Element("addresses");
            if (addressesElement != null)
            {
                XElement addressElement = addressesElement.Element("address");
                if (addressElement != null)
                {
                    txtStreet.Text = addressElement.Element("Street")?.Value;
                    txtBuildingNumber.Text = addressElement.Element("BuildingNumber")?.Value;
                    txtRegion.Text = addressElement.Element("region")?.Value;
                    txtCity.Text = addressElement.Element("City")?.Value;
                    txtCountry.Text = addressElement.Element("country")?.Value;
                }
            }
        }
        private void UpdateEmployee(XElement employeeElement)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtCountry.Text != "")
            {
                employeeElement.Element("name").Value = txtName.Text;
                employeeElement.Element("email").Value = txtEmail.Text;

                XElement phonesElement = employeeElement.Element("phones");
                if (phonesElement != null)
                {
                    XElement homePhoneElement = phonesElement.Elements("phone").FirstOrDefault(phone => phone.Attribute("type").Value == "home");
                    if (homePhoneElement != null)
                    {
                        homePhoneElement.Value = txtHomePhone.Text;
                    }

                    XElement workPhoneElement = phonesElement.Elements("phone").FirstOrDefault(phone => phone.Attribute("type").Value == "work");
                    if (workPhoneElement != null)
                    {
                        workPhoneElement.Value = txtWorkPhone.Text;
                    }

                    XElement mobilePhoneElement = phonesElement.Elements("phone").FirstOrDefault(phone => phone.Attribute("type").Value == "mobile");
                    if (mobilePhoneElement != null)
                    {
                        mobilePhoneElement.Value = txtMobilePhone.Text;
                    }
                }

                XElement addressesElement = employeeElement.Element("addresses");
                if (addressesElement != null)
                {
                    XElement addressElement = addressesElement.Element("address");
                    if (addressElement != null)
                    {
                        addressElement.Element("Street").Value = txtStreet.Text;
                        addressElement.Element("BuildingNumber").Value = txtBuildingNumber.Text;
                        addressElement.Element("region").Value = txtRegion.Text;
                        addressElement.Element("City").Value = txtCity.Text;
                        addressElement.Element("country").Value = txtCountry.Text;
                    }
                }

            }
            else
            {
                MessageBox.Show("Name, Email, Country are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateBtnState()
        {
            bool state = xmlDoc == null? false: true;
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    if (button.Name != "LoadBtn")
                    {
                        button.Enabled = state;
                    }

                }
                else if (control is GroupBox groupBox)
                {
                    foreach (Control innerControl in groupBox.Controls)
                    {
                        if (innerControl is Button innerButton)
                        {
                            if (innerButton.Name != "LoadBtn")
                            {
                                innerButton.Enabled = state;
                            }

                        }
                    }
                }
            }
        }

        //Event Handellers
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                try
                {
                    xmlDoc = XDocument.Load(filePath);
                    LoadAllIntoTreeView();
                    UpdateBtnState();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading XML file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            empTreeView.Nodes.Clear();
            string searchName = txtSearchName.Text.ToLower();
            if (searchName == "")
            {
                MessageBox.Show("Please Enter the name first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = xmlDoc.Root.Elements("employee")
                        .Select((emp, idx) => new { Employee = emp, Index = idx })
                        .FirstOrDefault(emp => emp.Employee.Element("name")?.Value.ToLower() == searchName)?.Index ?? -1;

                if (index != -1)
                {
                    currentEmployeeIndex = index;
                    LoadOneIntoTreeView();
                    txtSearchName.Clear();
                }
                else
                {
                    MessageBox.Show($"Employee: {searchName} Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    indexlabel.Text = $"Index = --";
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            empTreeView.Nodes.Clear();
            currentEmployeeIndex = -1;
            indexlabel.Text = $"Index = --";
            txtSearchName.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                xmlDoc.Save(filePath);
                MessageBox.Show("File Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (xmlDoc != null && currentEmployeeIndex < xmlDoc.Root.Elements("employee").Count() - 1)
            {
                currentEmployeeIndex++;
                LoadOneIntoTreeView();
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (xmlDoc != null && currentEmployeeIndex > 0)
            {
                currentEmployeeIndex--;
                LoadOneIntoTreeView();

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (xmlDoc != null && currentEmployeeIndex >= 0 && currentEmployeeIndex < xmlDoc.Root.Elements("employee").Count())
            {
                xmlDoc.Root.Elements("employee").ElementAt(currentEmployeeIndex).Remove();

                if (currentEmployeeIndex == xmlDoc.Root.Elements("employee").Count())
                    currentEmployeeIndex--;

                LoadAllIntoTreeView();
                empTreeView.Nodes.Clear();
                currentEmployeeIndex = -1;
                indexlabel.Text = $"Index = --";
            }
            else
            {
                MessageBox.Show("No employee to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (xmlDoc != null)
            {
                try
                {
                    if (txtName.Text != "" && txtEmail.Text != "" && txtCountry.Text != "")
                    {
                        XElement newEmployee = new XElement("employee",
                   new XElement("name", txtName.Text),
                   new XElement("phones",
                       new XElement("phone", new XAttribute("type", "home"), txtHomePhone.Text),
                       new XElement("phone", new XAttribute("type", "work"), txtWorkPhone.Text),
                       new XElement("phone", new XAttribute("type", "mobile"), txtMobilePhone.Text)
                   ),
                   new XElement("addresses",
                       new XElement("address",
                           new XElement("Street", txtStreet.Text),
                           new XElement("BuildingNumber", txtBuildingNumber.Text),
                           new XElement("region", txtRegion.Text),
                           new XElement("City", txtCity.Text),
                           new XElement("country", txtCountry.Text)
                       )
                   ),
                   new XElement("email", txtEmail.Text)
               );

                        xmlDoc.Root.Add(newEmployee);
                        LoadAllIntoTreeView();
                        ClearForm();
                        MessageBox.Show("Employee Inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Name, Email, Country are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else
            {
                MessageBox.Show("Load an XML file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (currentEmployeeIndex > -1)
            {
                XElement selectedElement = GetCurrentEmployee();
                FillForm(selectedElement);
            }
            else
            {
                MessageBox.Show("Select Employee first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (xmlDoc == null || !xmlDoc.Root.Elements("employee").Any())
                {
                    MessageBox.Show("No employees to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (currentEmployeeIndex < 0 || currentEmployeeIndex >= xmlDoc.Root.Elements("employee").Count())
                {
                    MessageBox.Show("Invalid current index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XElement currentEmployee = GetCurrentEmployee();
                    UpdateEmployee(currentEmployee);
                    LoadAllIntoTreeView();
                    LoadOneIntoTreeView();
                    ClearForm();
                    MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}
