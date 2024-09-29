using System.Diagnostics;

namespace Titans.ProjectStarter.Services
{
    public class UtilService
    {        
        const string _projectTemplateRepoUrl = "https://github.com/DavisSylvester/project-template-repo.git";
        private readonly string _tempDirectory = Path.GetTempPath();
        public UtilService() {        
            
        }

        public void CreateDiretory(string directoryName) {

            Directory.CreateDirectory(directoryName);
        }

        public void ReplaceTemplateText(string path, string value, string classifier) {

            string text = File.ReadAllText(path);
            text = text.Replace(classifier, value);
            File.WriteAllText(path, text);
        }

        public async Task CloneProjectTemplateRepo(string projectName, string gitRepoUrl = _projectTemplateRepoUrl, ) {
            
            string gitPath = Path.Combine(_tempDirectory, projectName);
                        
            Directory.CreateDirectory(gitPath);

            ProcessStartInfo gitClone = new ProcessStartInfo("git", $"clone {gitRepoUrl}");
            gitClone.RedirectStandardOutput = true;
            gitClone.RedirectStandardError = true;
            gitClone.UseShellExecute = false;
            gitClone.CreateNoWindow = true;

            Process gitProcess = new Process();
            gitProcess.StartInfo = gitClone;
            gitProcess.Start();
            await gitProcess.WaitForExitAsync();

            // if (Directory.Exists(gitPath)) {
            //     Directory.Delete(gitPath, true);
            // }

        }
    }
}
