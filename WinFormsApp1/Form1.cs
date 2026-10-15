using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBrowseFile1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFile1.Text = openFileDialog.FileName;
            }
        }

        private void ButtonBrowseFile2_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFile2.Text = openFileDialog.FileName;
            }
        }
        // Mohamed Njie
        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            listBoxTopWords1.Items.Clear();
            listBoxTopWords2.Items.Clear();

            var file1 = textBoxFile1.Text;
            var file2 = textBoxFile2.Text;

            if (string.IsNullOrWhiteSpace(file1) || string.IsNullOrWhiteSpace(file2))
            {
                MessageBox.Show("Please select both files before submitting.", "Files required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                var task1 = Task.Run(() => GetTopWordsFromFileAsync(file1));
                var task2 = Task.Run(() => GetTopWordsFromFileAsync(file2));

                await Task.WhenAll(task1, task2);

                var top1 = await task1;
                var top2 = await task2;

                foreach (var kv in top1)
                {
                    listBoxTopWords1.Items.Add($"{kv.Key} - {kv.Value}");
                }

                foreach (var kv in top2)
                {
                    listBoxTopWords2.Items.Add($"{kv.Key} - {kv.Value}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Mohamed Njie
        private async Task<List<KeyValuePair<string, int>>> GetTopWordsFromFileAsync(string path)
        {
            string text = await File.ReadAllTextAsync(path);

            text = text.ToLowerInvariant();

            var cleaned = Regex.Replace(text, "[^a-z0-9']+", " ");

            var words = cleaned.Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (var w in words)
            {
                var word = w.Trim('\'');
                if (string.IsNullOrWhiteSpace(word))
                    continue;

                if (word.Length == 1)
                    continue;

                if (counts.ContainsKey(word))
                    counts[word]++;
                else
                    counts[word] = 1;
            }

            var top = counts.OrderByDescending(kv => kv.Value).ThenBy(kv => kv.Key).Take(10).ToList();
            return top;
        }
    }
}
