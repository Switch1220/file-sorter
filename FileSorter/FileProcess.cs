using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace FileSorter
{
    public class FileProcess
    {
        public bool IsExist(string path, string name)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo fileInfo = new FileInfo($"{path}\\{name}");

            if (directoryInfo.Exists)
            {
                if (fileInfo.Exists)
                {
                    string textValue = File.ReadAllText($"{path}\\{name}");

                    if (textValue.Contains("property") == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public DataGridView ExtFilter(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string currentExt = dataGridView.Rows[i].Cells[1].Value.ToString();

                // 스페이스바 제거
                currentExt = System.Text.RegularExpressions.Regex.Replace(currentExt, @"\s+", string.Empty);

                int dotCount = currentExt.Split('.').Length - 1;

                List<string> extList = new List<string>();

                for (int j = 0; j < dotCount; j++)
                {
                    if (j == dotCount - 1)
                    {
                        extList.Add(currentExt);
                        break;
                    }

                    int firstP = currentExt.IndexOf('.');
                    int secondP = currentExt.IndexOf('.', firstP + 1);

                    extList.Add(currentExt.Substring(firstP, secondP));

                    currentExt = currentExt.Substring(secondP, currentExt.Length - secondP);
                }

                for (int k = 0; k < extList.Count; k++)
                {
                    if (k == 0)
                    {
                        dataGridView.Rows[i].Cells[1].Value = $"{extList[k]} ";
                    }
                    else
                    {
                        dataGridView.Rows[i].Cells[1].Value += $"{extList[k]} ";
                    }
                }
            }
                return dataGridView;
        }

        public bool IsNormalExt(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string currentExt = dataGridView.Rows[i].Cells[1].Value.ToString();

                // 스페이스바 제거
                currentExt = System.Text.RegularExpressions.Regex.Replace(currentExt, @"\s+", string.Empty);

                int dotCount = currentExt.Split('.').Length - 1;

                // 점 없으면
                if (dotCount == 0)
                {
                    return false;
                }
                // 아무글자도 없으면
                else if (currentExt == string.Empty)
                {
                    return false;
                }

                List<string> extList = new List<string>();

                for (int j = 0; j < dotCount; j++)
                {
                    if (j == dotCount - 1)
                    {
                        extList.Add(currentExt);
                        break;
                    }

                    int firstP = currentExt.IndexOf('.');
                    int secondP = currentExt.IndexOf('.', firstP + 1);

                    extList.Add(currentExt.Substring(firstP, secondP));

                    currentExt = currentExt.Substring(secondP, currentExt.Length - secondP);
                }

                foreach (string ext in extList)
                {
                    if (ext.Length == 1)
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }

        public List<string> MakeListByExt(DataTable dataTable, int rowIndex)
        {
            string currentExt = dataTable.Rows[rowIndex].ItemArray[1].ToString();

            // 스페이스바 제거
            currentExt = System.Text.RegularExpressions.Regex.Replace(currentExt, @"\s+", string.Empty);

            int dotCount = currentExt.Split('.').Length - 1;

            List<string> extList = new List<string>();

            for (int j = 0; j < dotCount; j++)
            {
                if (j == dotCount - 1)
                {
                    extList.Add(currentExt);
                    break;
                }

                int firstP = currentExt.IndexOf('.');
                int secondP = currentExt.IndexOf('.', firstP + 1);

                extList.Add(currentExt.Substring(firstP, secondP));

                currentExt = currentExt.Substring(secondP, currentExt.Length - secondP);
            }

            return extList;
        }

        public void CreateFolder(string path, string name)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo($"{path}\\{name}");

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

        public void CreateXml(string path, string name, DataTable dataTable)
        {
            dataTable.WriteXml($"{path}\\{name}", true);
        }

        public DataTable LoadDataTable(string path, string fileName)
        {
            System.Data.DataTable loadedDataTable = new DataTable("property");
            loadedDataTable.ReadXmlSchema(path + fileName);
            loadedDataTable.ReadXml(path + fileName);

            return loadedDataTable;
        }

        public bool MoveFile(string oldPath, string newPath)
        {
            FileInfo currentFile = new FileInfo(newPath);

            if (currentFile.Exists)
            {
                MessageBox.Show($"정리할 파일중 같은 이름의 파일이 존재합니다.\n이 파일은 이동하지 않고 계속 진행됩니다.\n 해당파일 : {currentFile.Name}", "File Sorter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                File.Move(oldPath, newPath);
                return true;
            }
        }
    }
}