using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using xCheatsFunctions;
using System.Threading;
// ...


namespace xCheats.Loader
{
    public partial class RDRO : Form
    {
        static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string appFolderPath = Path.Combine(appDataPath, "xCheats");
        static string configFilePath = Path.Combine(appFolderPath, "data\\Config\\config.ini");
        IniConfig config = new IniConfig();
        private string JsonFilePath;
        public RDRO()
        {
            InitializeComponent();
            string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            JsonFilePath = Path.Combine(roamingFolderPath + "\\Exodus Client\\", "Credentials.json");
            config.Load(configFilePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RDRO_Load(object sender, EventArgs e)
        {
            
            Pfad.Text = "Installationspfad: " + GlobalSettings.SelectedInstallPath;
            // Check if the SelectedInstallPath setting is not empty
            if (!string.IsNullOrEmpty(GlobalSettings.SelectedInstallPath))
            {
                // Disable the button when the path is already set
                //PfadBtn.Enabled = false;
            }
            int buttonModes = GlobalSettings.buttonMode;

            if (buttonModes == 1)
            {
                // Set button text to "Reset Path"
                PfadBtn.Text = "Reset Path";
            }
            else if (buttonModes == 0)
            {
                // Set button text to "Get Path"
                PfadBtn.Text = "Get Path";
            }

            if (File.Exists(JsonFilePath))
            {
                string jsonContent = File.ReadAllText(JsonFilePath);
                dynamic jsonData = JsonConvert.DeserializeObject(jsonContent);
                this.Size = new System.Drawing.Size(575, 190);
            }
            else
            {
                this.Size = new System.Drawing.Size(287, 190);
                
            }

        }

        private string GetRedDeadRedemption2InstallPath()
        {
            string keyPath = @"SOFTWARE\Wow6432Node\Rockstar Games\Red Dead Redemption 2";
            string installPath = GetValueFromRegistry(keyPath, "InstallFolder");
            string steamInstallPath = GetValueFromRegistry(keyPath, "InstallFolderSteam");

            // Retrieve the previously selected installation path from application settings
            string savedPath = GlobalSettings.SelectedInstallPath;

            if (!string.IsNullOrEmpty(installPath) && !string.IsNullOrEmpty(steamInstallPath))
            {
                if (!string.IsNullOrEmpty(savedPath) && (savedPath == installPath || savedPath == steamInstallPath))
                {
                    // The previously selected installation path is still valid, return it
                    return savedPath;
                }

                // Both installation paths exist, prompt the user to select one
                DialogResult result = MessageBox.Show("Multiple installations detected. Choose one:\n\n" +
                    "1. InstallFolder: " + installPath + "\n" +
                    "2. InstallFolderSteam: " + steamInstallPath + "\n\n" +
                    "Select 'Yes' for InstallFolder or 'No' for InstallFolderSteam.",
                    "Multiple Installations", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // User selected InstallFolder
                    installPath = savedPath != steamInstallPath ? installPath : null;
                }
                else
                {
                    // User selected InstallFolderSteam
                    installPath = savedPath != installPath ? steamInstallPath : null;
                }
            }
            else if (!string.IsNullOrEmpty(installPath))
            {
                // Only InstallFolder exists
                installPath = savedPath != installPath ? installPath : null;
            }
            else if (!string.IsNullOrEmpty(steamInstallPath))
            {
                // Only InstallFolderSteam exists
                installPath = savedPath != steamInstallPath ? steamInstallPath : null;
            }

            // Save the selected installation path in application settings
            GlobalSettings.SelectedInstallPath = installPath;

            return installPath;
        }

        private void RDOLCreate_Click(object sender, EventArgs e)
        {
            // Retrieve the installation path

            string installPath = GlobalSettings.SelectedInstallPath;

            if (!string.IsNullOrEmpty(installPath))
            {
                // Create the folder path
                string folderPath = Path.Combine(installPath, "x64", "data");

                // Adjust the folder path to remove the redundant "Red Dead Redemption 2" folder
                string fixedFolderPath = Path.Combine(folderPath, "..", "..", "..");

                // Check if the folder already exists
                if (!Directory.Exists(fixedFolderPath))
                {
                    // Create the folder if it doesn't exist
                    Directory.CreateDirectory(fixedFolderPath);
                }

                // Create the file path
                string filePath = Path.Combine(folderPath, "startup.meta");

                // Define the XML content for the file
                string fileContent = @"<?xml version=""1.0"" encoding=""UTF-8""?>
        <CDataFileMgr__ContentsOfDataFileXml>
            <disabledFiles />
            <includedXmlFiles itemType=""CDataFileMgr__DataFileArray"" />
            <includedDataFiles />
            <dataFiles itemType=""CDataFileMgr__DataFile"">
                <Item>
                    <filename>platform:/data/cdimages/scaleform_platform_pc.rpf</filename>
                    <fileType>RPF_FILE</fileType>
                </Item>
                <Item>
                    <filename>platform:/data/ui/value_conversion.rpf</filename>
                    <fileType>RPF_FILE</fileType>
                </Item>
                <Item>
                    <filename>platform:/data/ui/widgets.rpf</filename>
                    <fileType>RPF_FILE</fileType>
                </Item>
                <Item>
                    <filename>platform:/textures/ui/ui_photo_stickers.rpf</filename>
                    <fileType>RPF_FILE</fileType>
                </Item>
                <Item>
                    <filename>platform:/textures/ui/ui_platform.rpf</filename>
                    <fileType>RPF_FILE</fileType>
                </Item>
                <Item>
                    <filename>platform:/data/ui/stylesCatalog</filename>
                    <fileType>aWeaponizeDisputants</fileType> <!-- collision -->
                </Item>
                <Item>
                    <filename>platform:/data/cdimages/scaleform_frontend.rpf</filename>
                    <fileType>RPF_FILE_PRE_INSTALL</fileType>
                </Item>
                <Item>
                    <filename>platform:/textures/ui/ui_startup_textures.rpf</filename>
                    <fileType>RPF_FILE</fileType>
                </Item>
                <Item>
                    <filename>platform:/data/ui/startup_data.rpf</filename>
                    <fileType>RPF_FILE</fileType>
                </Item>
            </dataFiles>
            <contentChangeSets itemType=""CDataFileMgr__ContentChangeSet"" />
            <patchFiles />
        </CDataFileMgr__ContentsOfDataFileXml>";

                // Get the additional content from a TextBox
                string additionalContent = RDOContent.Text;

                // Append the additional content after the closing tag
                fileContent = fileContent.Replace("</CDataFileMgr__ContentsOfDataFileXml>", "</CDataFileMgr__ContentsOfDataFileXml>\n" + "\n" + "\n        " + additionalContent);

                // Create the file and write the content
                File.WriteAllText(filePath, fileContent);

                // Display a message to indicate successful file creation
                MessageBox.Show("Meta file created successfully.");
            }
            else
            {
                // Display an error message if the install path is empty or null
                MessageBox.Show("Unable to retrieve the installation path. Please make sure the path is valid.");
            }
        }

        private string GetValueFromRegistry(string keyPath, string valueName)
        {
            string value = null;

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath))
            {
                if (key != null)
                {
                    object registryValue = key.GetValue(valueName);
                    if (registryValue != null)
                    {
                        value = registryValue.ToString();
                    }
                }
            }

            return value;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            LoaderMain Main = new LoaderMain();
            Main.Show();
            this.Close();
        }

        private void ReloadForm()
        {
            Application.Restart();
        }

        private void PfadBtn_Click(object sender, EventArgs e)
        {

            int buttonModes = GlobalSettings.buttonMode;

            if (buttonModes == 1)
            {
               ResetPath();
            }
            else if (buttonModes == 0)
            {
                SetPath();
            }
        }
        private void SetPath()
        {
            // Function 1 logic goes here
            string installPath = GetRedDeadRedemption2InstallPath();

            // Save the installation path in the application settings
            config.SetValue("Path", "RedDead2", installPath.ToString());
            config.SetValue("Path", "RedDead2Btn", "1");
            config.Save(configFilePath);
            MessageBox.Show("Installation path retrieved and saved successfully.");
            Thread.Sleep(200);
            ReloadForm();
        }

        private void ResetPath()
        {
            config.SetValue("Path", "RedDead2", string.Empty);
            config.SetValue("Path", "RedDead2Btn", "0");
            config.Save(configFilePath);
            Thread.Sleep(200);
            ReloadForm();
        }

        private void GoPublicBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the installation path
            string installPath = GlobalSettings.SelectedInstallPath;

            if (!string.IsNullOrEmpty(installPath))
            {
                // Create the file path
                string filePath = Path.Combine(installPath, "x64", "data", "startup.meta");

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Delete the file
                    File.Delete(filePath);

                    // Display a message to indicate successful deletion
                    MessageBox.Show("File deleted successfully.");
                }
                else
                {
                    // Display a message if the file doesn't exist
                    MessageBox.Show("The file doesn't exist.");
                }
            }
            else
            {
                // Display an error message if the install path is empty or null
                MessageBox.Show("Unable to retrieve the installation path. Please make sure the path is valid.");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string eValue = Email.Text;
            string pValue = Password.Text;

            // Create a JSON object with the new values
            dynamic jsonData = new
            {
                e = eValue,
                p = pValue
            };

            try
            {
                // Serialize the JSON object and save it to the file
                string jsonContent = JsonConvert.SerializeObject(jsonData, Formatting.Indented);
                File.WriteAllText(JsonFilePath, jsonContent);

                // Inform the user that the data has been saved
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (JsonWriterException)
            {
                MessageBox.Show("Error writing data to JSON file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
