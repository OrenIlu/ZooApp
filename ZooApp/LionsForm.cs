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
    public partial class LionsForm : Form
    {
        private List<Lion> listOfLoins;
        public LionsForm()
        {
            InitializeComponent();
            listOfLoins = LoadMammal();
            listBox1.DataSource = listOfLoins;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericAge.Value == 0 || comboxRegion.SelectedIndex == -1 || txbxName.Text == "")
                {
                    throw new ArgumentNullException();
                }
                Lion newLion = new Lion()
                {
                    Age = (int)numericAge.Value,
                    Name = txbxName.Text,

                    Region = comboxRegion.SelectedItem.ToString(),
                    HasOffspring = chkHasOffspring.Checked ? true : false,
                    NumOffspring = chkHasOffspring.Checked ? new Random().Next(1, 11) : 0,

                    ManeLength = (int)numericManeLength.Value,
                    IsKing = chkIsKing.Checked ? true : false,
                };

                listOfLoins.Add(newLion);
                SaveLions(listOfLoins);
                listBox1.DataSource = null;
                listBox1.DataSource = listOfLoins;
                MessageBox.Show("Lion is Added to the Zoo", "Lion Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Lion Not Added!\nError: One or more values are missing", "Missing Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Lion Not Added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    if (numericAge.Value == 0 || txbxName.Text == "" || comboxRegion.SelectedIndex == -1)
                    {
                        throw new ArgumentException("Lion Not Updated!\nError: One or more values are missing");
                    }
                    // Get the selected Tiger
                    var selectedMammal = listBox1.SelectedItem as Lion;

                    // Update the Tigers's properties
                    selectedMammal.Age = (int)numericAge.Value;
                    selectedMammal.Name = txbxName.Text;
                    selectedMammal.Region = comboxRegion.SelectedItem.ToString();
                    selectedMammal.HasOffspring = chkHasOffspring.Checked ? true : false;
                    if (chkHasOffspring.Checked && selectedMammal.NumOffspring == 0)
                    {
                        selectedMammal.NumOffspring = new Random().Next(1, 11);
                    }
                    else if (chkHasOffspring.Checked == false && selectedMammal.NumOffspring != 0)
                    {
                        selectedMammal.NumOffspring = 0;
                    }
                    selectedMammal.ManeLength = (int)numericManeLength.Value;
                    selectedMammal.IsKing = chkIsKing.Checked ? true : false;



                    // Refresh the ListBox to reflect the changes
                    listBox1.DataSource = null;
                    listBox1.DataSource = listOfLoins;
                    SaveLions(listOfLoins);

                    MessageBox.Show("Lion is Updated to the Zoo", "Lion Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Lion Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select Lion To Update", "Lion Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Get the selected Fish
                var selectedMammal = listBox1.SelectedItem as Lion;

                // Remove the Fish from the list
                listOfLoins.Remove(selectedMammal);

                SaveLions(listOfLoins);
                listBox1.DataSource = null;
                // Refresh the ListBox to reflect the changes
                listBox1.DataSource = listOfLoins;
                btnClear_Click(sender, e);
                MessageBox.Show("Lion is Removed in the Zoo.", "Lion Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select Lion To Delete", "Lion Not Removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedAnimal = (Lion)listBox1.SelectedItem;

                // Perform actions based on the selected Lion
                numericAge.Value = selectedAnimal.Age;
                txbxName.Text = selectedAnimal.Name;
                comboxRegion.SelectedItem = selectedAnimal.Region;
                chkHasOffspring.Checked = selectedAnimal.HasOffspring ? true : false;
                numericManeLength.Value = selectedAnimal.ManeLength;
                chkIsKing.Checked = selectedAnimal.IsKing ? true : false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            numericAge.Value = 0;
            txbxName.Text = "";
            comboxRegion.SelectedIndex = -1;
            chkHasOffspring.Checked = false;
            numericManeLength.Value = 0;
            chkIsKing.Checked = false;
        }
        private List<Lion> LoadMammal()
        {
            List<Lion> mammal;

            using (FileStream fileStream = new FileStream("Lions.bin", FileMode.Open))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Lion>));
                mammal = (List<Lion>)serializer.ReadObject(fileStream);
            }

            return mammal;
        }
        private void SaveLions(List<Lion> listOfLoins)
        {
            using (FileStream fileStream = new FileStream("Lions.bin", FileMode.Create))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Lion>));
                serializer.WriteObject(fileStream, listOfLoins);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    var selectedAnimal = listBox1.SelectedItem as Lion;
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
                MessageBox.Show("Error: No Lion was Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(ZooApp.Properties.Resources.Lion_Sound);
            audio.Play();
        }
    }
}
