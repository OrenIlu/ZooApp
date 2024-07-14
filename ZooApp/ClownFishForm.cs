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
    public partial class ClownFishForm : Form
    {
        private List<Clownfish> listOfLoins;

        public ClownFishForm()
        {
            InitializeComponent();
            listOfLoins = LoadFish();
            listBox1.DataSource = listOfLoins;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericAge.Value == 0 || comboxWaterType.SelectedIndex == -1 || txbxName.Text == "" || comboxSpecies.SelectedIndex == -1)
                {
                    throw new ArgumentNullException();
                }
                Clownfish newClownFish = new Clownfish()
                {
                    Age = (int)numericAge.Value,
                    Name = txbxName.Text,

                    HasTracker = chkHasTracker.Checked ? true : false,
                    TrackerID = chkHasTracker.Checked ? GenerateRandomID() : "No Tracker",
                    WaterType = comboxWaterType.SelectedItem.ToString(),

                    IsNemo = chkIsNemo.Checked ? true : false,
                    Species = comboxSpecies.SelectedItem.ToString(),
                };

                listOfLoins.Add(newClownFish);
                SaveClownFish(listOfLoins);
                listBox1.DataSource = null;
                listBox1.DataSource = listOfLoins;
                MessageBox.Show("Clown Fish is Added to the Zoo.", "Clown Fish Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Clown Fish Not Added!\nError: One or more values are missing", "Missing Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Clown Fish Not Added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    if (numericAge.Value == 0 || comboxWaterType.SelectedIndex == -1 || txbxName.Text == "" || comboxSpecies.SelectedIndex == -1)
                    {
                        throw new ArgumentException("Clown Fish Not Updated!\nError: One or more values are missing");
                    }
                    // Get the selected Fish
                    var selectedFish = listBox1.SelectedItem as Clownfish;

                    // Update the bird's properties
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
                    selectedFish.IsNemo = chkIsNemo.Checked ? true : false;
                    selectedFish.Species = comboxSpecies.SelectedItem.ToString();

                    // Refresh the ListBox to reflect the changes
                    listBox1.DataSource = null;
                    listBox1.DataSource = listOfLoins;
                    //listboxBirds.DisplayMember = "Name";
                    SaveClownFish(listOfLoins);

                    MessageBox.Show("Clown Fish is Updated to the Zoo.", "Clown Fish Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Clown Fish Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select Clown Fish To Update", "Clown Fish Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Get the selected bird
                var selectedMammal = listBox1.SelectedItem as Clownfish;

                // Remove the bird from the list
                listOfLoins.Remove(selectedMammal);

                SaveClownFish(listOfLoins);
                listBox1.DataSource = null;
                // Refresh the ListBox to reflect the changes
                listBox1.DataSource = listOfLoins;
                btnClear_Click(sender, e);
                MessageBox.Show("Clown Fish is Removed in the Zoo.", "Clown Fish Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select Clown Fish To Delete", "Clown Fish Not Removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedAnimal = (Clownfish)listBox1.SelectedItem;

                // Perform actions based on the selected animal
                numericAge.Value = selectedAnimal.Age;
                txbxName.Text = selectedAnimal.Name;
                chkHasTracker.Checked = selectedAnimal.HasTracker ? true : false;
                comboxWaterType.SelectedItem = selectedAnimal.WaterType;
                chkIsNemo.Checked = selectedAnimal.IsNemo ? true : false;
                comboxSpecies.SelectedItem = selectedAnimal.Species;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            numericAge.Value = 0;
            txbxName.Text = "";
            chkHasTracker.Checked = false;
            comboxWaterType.SelectedIndex = -1;
            chkIsNemo.Checked = false;
            comboxSpecies.SelectedIndex = -1;
        }

        private List<Clownfish> LoadFish()
        {
            List<Clownfish> fish;

            using (FileStream fileStream = new FileStream("clownfish.bin", FileMode.Open))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Clownfish>));
                fish = (List<Clownfish>)serializer.ReadObject(fileStream);
            }

            return fish;
        }
        private void SaveClownFish(List<Clownfish> listOfLoins)
        {
            using (FileStream fileStream = new FileStream("clownfish.bin", FileMode.Create))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Clownfish>));
                serializer.WriteObject(fileStream, listOfLoins);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    var selectedAnimal = listBox1.SelectedItem as Clownfish;
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
                MessageBox.Show("Error: No Clown Fish was Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSound_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(ZooApp.Properties.Resources.ClownFish_Sound);
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
