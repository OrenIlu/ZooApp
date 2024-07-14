using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class TigersForm : Form
    {
        private List<Tiger> listOfLoins;
        public TigersForm()
        {
            InitializeComponent();
            listOfLoins = LoadMammal();
            listBox1.DataSource = listOfLoins;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericAge.Value == 0 || comboxRegion.SelectedIndex == -1 || txbxName.Text == ""||comboxFurColor.SelectedIndex==-1)
                {
                    throw new ArgumentNullException();
                }
                Tiger newTiger = new Tiger()
                {
                    Age = (int)numericAge.Value,
                    Name = txbxName.Text,

                    Region = comboxRegion.SelectedItem.ToString(),
                    HasOffspring = chkHasOffspring.Checked ? true : false,
                    NumOffspring = chkHasOffspring.Checked ? new Random().Next(1, 11) : 0,

                    FurColor = comboxRegion.SelectedItem.ToString(),
                    StripeCount=(int)numericStripeCount.Value,
                };
                if (newTiger.Age == 0 || newTiger.Region == null || newTiger.Name == null || newTiger.FurColor==null || newTiger.StripeCount == 0)
                {
                    throw new ArgumentNullException();
                }
                listOfLoins.Add(newTiger);
                SaveTigers(listOfLoins);
                listBox1.DataSource = null;
                listBox1.DataSource = listOfLoins;
                MessageBox.Show("Tiger is Added to the Zoo.", "Tiger Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show($"Tiger Not Added!\nError: One or more values are missing", "Missing Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Tiger Not Added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    if (numericAge.Value == 0 || comboxRegion.SelectedIndex == -1 || txbxName.Text == "" || comboxFurColor.SelectedIndex == -1)
                    {
                        throw new ArgumentException("Tiger Not Updated!\nError: One or more values are missing");
                    }
                    // Get the selected Tiger
                    var selectedMammal = listBox1.SelectedItem as Tiger;

                    // Update the Tigers's properties
                    selectedMammal.Age = (int)numericAge.Value;
                    selectedMammal.Name = txbxName.Text;
                    selectedMammal.Region = comboxRegion.SelectedItem.ToString();
                    selectedMammal.HasOffspring = chkHasOffspring.Checked ? true : false;
                    if (chkHasOffspring.Checked && selectedMammal.NumOffspring==0)
                    {
                        selectedMammal.NumOffspring = new Random().Next(1, 11);
                    }
                    else if (chkHasOffspring.Checked == false && selectedMammal.NumOffspring != 0)
                    {
                        selectedMammal.NumOffspring = 0;
                    }
                    selectedMammal.FurColor = comboxFurColor.SelectedItem.ToString();
                    selectedMammal.StripeCount = (int)numericStripeCount.Value;


                    // Refresh the ListBox to reflect the changes
                    listBox1.DataSource = null;
                    listBox1.DataSource = listOfLoins;
                    SaveTigers(listOfLoins);

                    MessageBox.Show("Tiger is Updated to the Zoo.", "Tiger Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Tiger Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select Tiger To Update", "Tiger Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Get the selected Fish
                var selectedMammal = listBox1.SelectedItem as Tiger;

                // Remove the Fish from the list
                listOfLoins.Remove(selectedMammal);

                SaveTigers(listOfLoins);
                listBox1.DataSource = null;
                // Refresh the ListBox to reflect the changes
                listBox1.DataSource = listOfLoins;
                btnClear_Click(sender, e);
                MessageBox.Show("Tiger is Removed in the Zoo.", "Tiger Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select Tiger To Delete", "Tiger Not Removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedAnimal = (Tiger)listBox1.SelectedItem;

                // Perform actions based on the selected Tiger
                numericAge.Value = selectedAnimal.Age;
                txbxName.Text = selectedAnimal.Name;
                comboxRegion.SelectedItem = selectedAnimal.Region;
                chkHasOffspring.Checked = selectedAnimal.HasOffspring ? true : false;
                comboxFurColor.SelectedItem = selectedAnimal.FurColor;
                numericStripeCount.Value = selectedAnimal.StripeCount;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            numericAge.Value = 0;
            txbxName.Text = "";
            comboxRegion.SelectedIndex = -1;
            chkHasOffspring.Checked = false;          
            comboxFurColor.SelectedIndex = -1;
            numericStripeCount.Value = 0;
        }
        private List<Tiger> LoadMammal()
        {
            List<Tiger> mammal;

            using (FileStream fileStream = new FileStream("Tigers.bin", FileMode.Open))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Tiger>));
                mammal = (List<Tiger>)serializer.ReadObject(fileStream);
            }

            return mammal;
        }
        private void SaveTigers(List<Tiger> listOfLoins)
        {
            using (FileStream fileStream = new FileStream("Tigers.bin", FileMode.Create))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Tiger>));
                serializer.WriteObject(fileStream, listOfLoins);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    var selectedAnimal = listBox1.SelectedItem as Tiger;
                    string pictureName = selectedAnimal.ShowPicture();

                    // Check if the picture name is valid
                    if (!string.IsNullOrEmpty(pictureName))
                    {
                        // Construct the path to the picture based on the picture name
                        var picture = (Image)Properties.Resources.ResourceManager.GetObject(pictureName);

                        if (picture != null)
                        {
                            // Display the picture in a popup window
                            using (Form pictureForm = new Form())
                            {
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.Image = picture;
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox.Dock = DockStyle.Fill;

                                pictureForm.Controls.Add(pictureBox);
                                pictureForm.StartPosition = FormStartPosition.CenterScreen;
                                pictureForm.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Picture not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid picture name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: No Tiger was Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSound_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(ZooApp.Properties.Resources.Tiger_Sound);
            audio.Play();
        }
    }
}
