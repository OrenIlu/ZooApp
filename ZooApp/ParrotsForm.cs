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
    public partial class ParrotsForm : Form
    {
        private List<Parrot> listOfLoins;
        public ParrotsForm()
        {
            InitializeComponent();
            listOfLoins = LoadBird();
            listBox1.DataSource = listOfLoins;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericAge.Value == 0 || comboxDiet.SelectedIndex == -1 || txbxName.Text == "" || comboxColor.SelectedIndex==-1)
                {
                    throw new ArgumentNullException();
                }
                Parrot newParrot = new Parrot()
                {
                    Age = (int)numericAge.Value,
                    Name = txbxName.Text,

                    CanFly = chkCanFly.Checked ? true : false,
                    Diet = comboxDiet.SelectedItem.ToString(),
                    Milage= chkCanFly.Checked ? new Random().Next(1, 2000) : 0,

                    Color = comboxColor.SelectedItem.ToString(),
                    CanSpeak = chkCanSpeak.Checked ? true : false,
                };

                listOfLoins.Add(newParrot);
                SaveParrots(listOfLoins);
                listBox1.DataSource = null;
                listBox1.DataSource = listOfLoins;
                MessageBox.Show("Parrot is Added to the Zoo", "Parrot Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Parrot Not Added!\nError: One or more values are missing", "Missing Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Parrot Not Added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    if (numericAge.Value == 0 || comboxDiet.SelectedIndex == -1 || txbxName.Text == "" || comboxColor.SelectedIndex == -1)
                    {
                        throw new ArgumentException("Parrot Not Updated!\nError: One or more values are missing");
                    }
                    // Get the selected Tiger
                    var selectedBird = listBox1.SelectedItem as Parrot;

                    // Update the Tigers's properties
                    selectedBird.Age = (int)numericAge.Value;
                    selectedBird.Name = txbxName.Text;
                    selectedBird.CanFly = chkCanFly.Checked ? true : false;
                    if (chkCanFly.Checked && selectedBird.Milage == 0)
                    {
                        selectedBird.Milage = new Random().Next(1, 2000);
                    }
                    else if (chkCanFly.Checked == false && selectedBird.Milage != 0)
                    {
                        selectedBird.Milage = 0;
                    }
                    selectedBird.Diet = comboxDiet.SelectedItem.ToString();
                    selectedBird.Color = comboxColor.SelectedItem.ToString();
                    selectedBird.CanSpeak = chkCanSpeak.Checked ? true : false;


                    // Refresh the ListBox to reflect the changes
                    listBox1.DataSource = null;
                    listBox1.DataSource = listOfLoins;
                    SaveParrots(listOfLoins);

                    MessageBox.Show("Parrot is Updated to the Zoo", "Parrot Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Parrot Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select Parrot To Update", "Parrot Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Get the selected Fish
                var selectedBird = listBox1.SelectedItem as Parrot;

                // Remove the Fish from the list
                listOfLoins.Remove(selectedBird);

                SaveParrots(listOfLoins);
                listBox1.DataSource = null;
                // Refresh the ListBox to reflect the changes
                listBox1.DataSource = listOfLoins;
                btnClear_Click(sender, e);
                MessageBox.Show("Parrot is Removed in the Zoo.", "Parrot Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select Parrot To Delete", "Parrot Not Removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedAnimal = (Parrot)listBox1.SelectedItem;

                // Perform actions based on the selected Parrot
                numericAge.Value = selectedAnimal.Age;
                txbxName.Text = selectedAnimal.Name;
                chkCanFly.Checked = selectedAnimal.CanFly;
                comboxDiet.SelectedItem = selectedAnimal.Diet;
                comboxColor.SelectedItem = selectedAnimal.Color;
                chkCanSpeak.Checked = selectedAnimal.CanSpeak ? true : false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            numericAge.Value = 0;
            txbxName.Text = "";
            chkCanFly.Checked = false;
            comboxDiet.SelectedIndex = -1;
            comboxColor.SelectedIndex = -1;
            chkCanSpeak.Checked = false;
        }
        private List<Parrot> LoadBird()
        {
            List<Parrot> Bird;

            using (FileStream fileStream = new FileStream("Parrots.bin", FileMode.Open))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Parrot>));
                Bird = (List<Parrot>)serializer.ReadObject(fileStream);
            }

            return Bird;
        }
        private void SaveParrots(List<Parrot> listOfLoins)
        {
            using (FileStream fileStream = new FileStream("Parrots.bin", FileMode.Create))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Parrot>));
                serializer.WriteObject(fileStream, listOfLoins);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    var selectedAnimal = listBox1.SelectedItem as Parrot;
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
                MessageBox.Show("Error: No Parrot was Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSound_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(ZooApp.Properties.Resources.Parrot_Sound);
            audio.Play();
        }
    }
}