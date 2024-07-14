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
    public partial class DolphinsForm : Form
    {
        private List<Dolphin> listOfLoins;
        public DolphinsForm()
        {
            InitializeComponent();
            listOfLoins = LoadFish();
            listBox1.DataSource = listOfLoins;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericAge.Value == 0 || comboxWaterType.SelectedIndex==-1 || txbxName.Text == "")
                {
                    throw new ArgumentNullException();
                }
                Dolphin newDolphin = new Dolphin()
                {
                    Age = (int)numericAge.Value,
                    Name = txbxName.Text,

                    HasTracker = chkHasTracker.Checked ? true : false,
                    TrackerID = chkHasTracker.Checked ? GenerateRandomID() : "No Tracker",
                    WaterType = comboxWaterType.SelectedItem.ToString(),
                    
                    IsTrained = chkIsTrained.Checked ? true : false,
                    Color = comboxColor.SelectedItem.ToString(),
                };
                if (newDolphin.Age == 0 || newDolphin.WaterType == null || newDolphin.Name == "" || newDolphin.Color == null)
                {
                    throw new ArgumentNullException();
                }
                listOfLoins.Add(newDolphin);
                SaveDolphins(listOfLoins);
                listBox1.DataSource = null;
                listBox1.DataSource = listOfLoins;
                MessageBox.Show("Dolphin is Added to the Zoo.", "Dolphin Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Dolphin Not Added!\nError: One or more values are missing", "Missing Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Dolphin Not Added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    if (numericAge.Value == 0 || txbxName.Text == "" || comboxWaterType.SelectedIndex == -1)
                    {
                        throw new ArgumentException("Dolphin Not Updated!\nError: One or more values are missing");
                    }
                    // Get the selected Dolphin
                    var selectedFish = listBox1.SelectedItem as Dolphin;

                    // Update the Dolphins's properties
                    selectedFish.Age = (int)numericAge.Value;
                    selectedFish.Name = txbxName.Text;
                    selectedFish.HasTracker = chkHasTracker.Checked ? true : false;
                    if (chkHasTracker.Checked && selectedFish.TrackerID == "No Tracker")
                    {
                        selectedFish.TrackerID = GenerateRandomID();
                    }
                    else if (chkHasTracker.Checked == false && selectedFish.TrackerID != "No Tracker")
                    {
                        selectedFish.TrackerID = "No Tracker";
                    }
                    selectedFish.WaterType = comboxWaterType.SelectedItem.ToString();
                    selectedFish.IsTrained = chkIsTrained.Checked ? true : false;
                    selectedFish.Color = comboxColor.SelectedItem.ToString();


                    // Refresh the ListBox to reflect the changes
                    listBox1.DataSource = null;
                    listBox1.DataSource = listOfLoins;
                    SaveDolphins(listOfLoins);

                    MessageBox.Show("Dolphin is Updated to the Zoo.", "Dolphin Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Dolphin Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select Dolphin To Update", "Dolphin Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Get the selected Fish
                var selectedFish = listBox1.SelectedItem as Dolphin;

                // Remove the Fish from the list
                listOfLoins.Remove(selectedFish);

                SaveDolphins(listOfLoins);
                listBox1.DataSource = null;
                // Refresh the ListBox to reflect the changes
                listBox1.DataSource = listOfLoins;
                btnClear_Click(sender, e);
                MessageBox.Show("Dolphin is Removed in the Zoo.", "Dolphin Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select Dolphin To Delete", "Dolphin Not Removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedAnimal = (Dolphin)listBox1.SelectedItem;

                // Perform actions based on the selected Dolphin
                numericAge.Value = selectedAnimal.Age;
                txbxName.Text = selectedAnimal.Name;
                chkHasTracker.Checked = selectedAnimal.HasTracker ? true : false;
                comboxWaterType.SelectedItem = selectedAnimal.WaterType;               
                chkIsTrained.Checked = selectedAnimal.IsTrained ? true : false;
                comboxColor.SelectedItem = selectedAnimal.Color;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            numericAge.Value = 0;
            txbxName.Text = "";
            chkHasTracker.Checked = false;
            comboxWaterType.SelectedIndex = -1;
            chkIsTrained.Checked = false;
            comboxColor.SelectedIndex = -1; 
        }
        private List<Dolphin> LoadFish()
        {
            List<Dolphin> fish;

            using (FileStream fileStream = new FileStream("dolphins.bin", FileMode.Open))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Dolphin>));
                fish = (List<Dolphin>)serializer.ReadObject(fileStream);
            }

            return fish;
        }
        private void SaveDolphins(List<Dolphin> listOfLoins)
        {
            using (FileStream fileStream = new FileStream("dolphins.bin", FileMode.Create))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Dolphin>));
                serializer.WriteObject(fileStream, listOfLoins);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    var selectedAnimal = listBox1.SelectedItem as Dolphin;
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
                MessageBox.Show("Error: No Dolphin was Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSound_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(ZooApp.Properties.Resources.Dolphin_Sound);
            audio.Play();
        }
        private string GenerateRandomID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }
    }
}
