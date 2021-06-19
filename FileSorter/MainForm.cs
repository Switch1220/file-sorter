using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FileSorter
{
    public partial class MainForm : Form
    {
        FileProcess fileProcess = new FileProcess();

        // 선택된 항목 저장
        List<int> selectedItem = new List<int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 중복실행방지
            bool CreateNew;

            Mutex m = new Mutex(true, "FIRST", out CreateNew);
            if (!CreateNew)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;


                MessageBox.Show("이미 실행중입니다.", "File Sorter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                if (fileProcess.IsExist(Application.StartupPath + "\\" + "Setting File", @"\Setting.xml") == false)
                {
                    InitDataTable();
                    Addlog("Setting File 폴더를 생성했습니다.");
                    Addlog("Setting.xml 파일을 생성했습니다");
                }

                // 존재여부 상관없이 실행
                RefreshCheckList();
                RefreshDataGrid();

                // 모두 선택
                SelAllOrDeSelAll(true);
            }
        }

        public void InitDataTable()
        {
            // 초기 설정
            DataTable extDataTable = new DataTable("property");

            extDataTable.Columns.Add("이름");
            extDataTable.Columns.Add("확장자");

            DataRow dataRow;

            // 사진
            dataRow = extDataTable.NewRow();
            dataRow[0] = "사진 파일";
            dataRow[1] = ".png .jpg";

            extDataTable.Rows.Add(dataRow);

            // 동영상
            dataRow = extDataTable.NewRow();
            dataRow[0] = "동영상 파일";
            dataRow[1] = ".mp4 .avi";

            extDataTable.Rows.Add(dataRow);

            // 음악
            dataRow = extDataTable.NewRow();
            dataRow[0] = "음악 파일";
            dataRow[1] = ".mp3 .wav";

            extDataTable.Rows.Add(dataRow);

            // 문서
            dataRow = extDataTable.NewRow();
            dataRow[0] = "문서 파일";
            dataRow[1] = ".ppt .doc .xls";

            extDataTable.Rows.Add(dataRow);

            // 압축
            dataRow = extDataTable.NewRow();
            dataRow[0] = "압축 파일";
            dataRow[1] = ".zip .rar .7z";

            extDataTable.Rows.Add(dataRow);

            // 텍스트
            dataRow = extDataTable.NewRow();
            dataRow[0] = "텍스트 파일";
            dataRow[1] = ".txt";

            extDataTable.Rows.Add(dataRow);

            fileProcess.CreateFolder(Application.StartupPath, "Setting File");

            fileProcess.CreateXml(Application.StartupPath + "\\" + "Setting File", "Setting.xml", extDataTable);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 설정탭을 선택하면 데이터그리드 재설정
            if (tabControl.SelectedIndex == 1)
            {
                selectedItem.Clear();

                for (int i = 0; i < extListBox.Items.Count; i++)
                {
                    if (extListBox.GetItemChecked(i) == true)
                    {
                        selectedItem.Add(i);
                    }
                }

                RefreshDataGrid();
            }
            // 기본탭을 선택하면 체크리스트 재설정
            else
            {
                RefreshCheckList();

                if (extListBox.Items.Count > selectedItem.Count)
                {
                    for (int i = 0; i < selectedItem.Count; i++)
                    {
                        extListBox.SetItemChecked(selectedItem[i], true);
                    }
                }
                else
                {
                    for (int i = 0; i < extListBox.Items.Count; i++)
                    {
                        extListBox.SetItemChecked(selectedItem[i], true);
                    }
                }
            }
        }

        public void SelAllOrDeSelAll(bool trueIsSel)
        {
            for (int i = 0; i < extListBox.Items.Count; i++)
            {
                extListBox.SetItemChecked(i, trueIsSel);
            }
        }

        private void selectAllBtn_Click(object sender, EventArgs e)
        {
            SelAllOrDeSelAll(true);
        }

        private void deselectBtn_Click(object sender, EventArgs e)
        {
            SelAllOrDeSelAll(false);
        }

        private void folderSelBtn_Click(object sender, EventArgs e)
        {
            // 폴더브라우저 열고 ok 눌렀나 확인
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                currentPathTextBox.Text = folderBrowser.SelectedPath;
                Addlog($"{folderBrowser.SelectedPath} 경로를 선택했습니다");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (fileProcess.IsNormalExt(extDataGrid))
            {
                DataTable currentData = (DataTable)fileProcess.ExtFilter(extDataGrid).DataSource;

                fileProcess.CreateXml(Application.StartupPath + "\\" + "Setting File", "Setting.xml", currentData);

                RefreshDataGrid();
                RefreshCheckList();

                if (extListBox.Items.Count > selectedItem.Count)
                {
                    for (int i = 0; i < selectedItem.Count; i++)
                    {
                        extListBox.SetItemChecked(selectedItem[i], true);
                    }
                }
                else
                {
                    for (int i = 0; i < extListBox.Items.Count; i++)
                    {
                        extListBox.SetItemChecked(selectedItem[i], true);
                    }
                }

                Addlog($"확장자를 저장했습니다");
            }
            else
            {
                MessageBox.Show("확장자를 입력하세요", "File Sorter",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < extDataGrid.Rows.Count - 1; i++)
            {
                if (extDataGrid.Rows[i].Selected == true)
                {
                    extDataGrid.Rows.Remove(extDataGrid.Rows[i]);
                }
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        public void RefreshCheckList()
        {
            DataTable loadedDataTable = fileProcess.LoadDataTable(Application.StartupPath + "\\" + "Setting File", @"\Setting.xml");

            extListBox.Items.Clear();

            foreach (DataRow row in loadedDataTable.Rows)
            {
                extListBox.Items.Add($"{row[0]} ( {row[1]} )");
            }
        }

        public void RefreshDataGrid()
        {
            if (fileProcess.IsExist(Application.StartupPath + "\\" + "Setting File", @"\Setting.xml") == false)
            {
                InitDataTable();
            }

            DataTable loadedDataTable = fileProcess.LoadDataTable(Application.StartupPath + "\\" + "Setting File", @"\Setting.xml");

            extDataGrid.DataSource = loadedDataTable;
        }

        public bool IsCheckedAndSelected()
        {
            if (extListBox.CheckedItems.Count == 0 && currentPathTextBox.Text == "C:\\폴더를 선택해주세요")
            {
                MessageBox.Show("폴더와 확장자를 선택해주세요", "File Sorter", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // 메소드 종료
                return false;
            }

            // 경로선택했는지 확인
            if (currentPathTextBox.Text == "C:\\폴더를 선택해주세요")
            {
                MessageBox.Show("폴더를 선택해주세요", "File Sorter", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // 메소드 종료
                return false;
            }

            // 체크했는지 확인
            if (extListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("확장자를 선택해주세요", "File Sorter", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // 메소드 종료
                return false;
            }

            return true;
        }

        public void startBtn_Click(object sender, EventArgs e)
        {
            // 만약 폴더가 없을시
            if (fileProcess.IsExist(Application.StartupPath + "\\" + "Setting File", @"\Setting.xml") == false)
            {
                InitDataTable();
                RefreshCheckList();
                MessageBox.Show("Setting.xml 파일이 존재하지않습니다. 다시 생성됩니다.", "File Sorter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 선택했는지 검사
            if (IsCheckedAndSelected())
            {
                // 선택한 경로 저장
                string currentPath = currentPathTextBox.Text;

                // 속도 위해 먼저 빈폴더 정리
                if (delEmptyFolder.Checked == true)
                {
                    processDirectory(currentPath);
                }

                // 데이터 테이블 가져오기
                DataTable loadedDataTable = fileProcess.LoadDataTable(Application.StartupPath + "\\" + "Setting File", @"\Setting.xml");
                Addlog("리스트를 가져왔습니다");

                // 선택된 목록 저장할 리스트
                List<int> checkedItemList = new List<int>();

                // 반복하며 체크되어있는 항목을 리스트에 넣음
                for (int i = 0; i < extListBox.CheckedItems.Count; i++)
                {
                    checkedItemList.Add(extListBox.CheckedIndices[i]);
                }

                foreach (int checkedItem in checkedItemList)
                {
                    fileProcess.CreateFolder(currentPath, loadedDataTable.Rows[checkedItem].ItemArray[0].ToString());
                    Addlog($"{loadedDataTable.Rows[checkedItem].ItemArray[0]} 폴더를 생성했습니다");

                    List<string> extList = fileProcess.MakeListByExt(loadedDataTable, checkedItem);

                    foreach (string ext in extList)
                    {
                        string[] currentFileList = { };

                        // 하위디렉토리까지 정리
                        if (allDirOrThisDir.Checked == true)
                        {
                            currentFileList = Directory.GetFiles(currentPath, $"*{ext}", SearchOption.AllDirectories);
                        }
                        else if (allDirOrThisDir.Checked == false)
                        {
                            currentFileList = Directory.GetFiles(currentPath, $"*{ext}");
                        }
                            
                        Addlog("경로를 가져왔습니다");

                        foreach (string item in currentFileList)
                        {
                            string filePath = Path.GetDirectoryName(item);
                            string fileName = Path.GetFileName(item);

                            if (fileProcess.MoveFile(item, currentPath + "\\" + loadedDataTable.Rows[checkedItem].ItemArray[0] + "\\" + fileName))
                            {
                                Addlog($"{currentPath}\\{loadedDataTable.Rows[checkedItem].ItemArray[0]}\\{fileName} 로 파일을 이동했습니다");
                            }
                            else
                            {
                                System.Diagnostics.Process.Start(filePath);

                                Addlog($"정리할 파일중 같은 이름의 파일이 존재합니다. 해당파일 : {fileName}");
                            }
                        }
                    }
                }

                if (delEmptyFolder.Checked == true)
                {
                    processDirectory(currentPath);
                }

                progressBar.Value += 100;

                if (MessageBox.Show("완료되었습니다.", "File Sorter", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    progressBar.Value = 0;

                    System.Diagnostics.Process.Start(currentPath);
                }
            }
        }

        private void processDirectory(string startLocation)
        {
            foreach (var directory in Directory.GetDirectories(startLocation))
            {
                processDirectory(directory);
                if (Directory.GetFiles(directory).Length == 0 && Directory.GetDirectories(directory).Length == 0)
                {
                    try { Directory.Delete(directory, false); }
                    catch (IOException) { }
                    catch (UnauthorizedAccessException) { }
                }
            }
        }

        public void Addlog(string log)
        {
            logTextBox.Text += (log + "\r\n");
        }

        private void allDirOrThisDir_CheckedChanged(object sender, EventArgs e)
        {
            if (allDirOrThisDir.Checked == false)
            {
                delEmptyFolder.Enabled = false;
                delEmptyFolder.Checked = false;
            }
            else
            {
                delEmptyFolder.Enabled = true;
            }
        }
    }
}
