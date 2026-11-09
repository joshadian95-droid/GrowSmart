namespace GrowSmart
{
    public partial class Form1 : Form
    {
        private List<Plant> _allPlants = new();
        private const int MaxShown = 1000;
        public Form1()
        {
            InitializeComponent();
            lstPlants.DisplayMember = nameof(Plant.ListLabel);
            txtSearch.TextChanged += (s, e) => ApplyFilter();
            lstPlants.SelectedIndexChanged += (s, e) => UpdateResult();
            Load += Form1_Load;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            lblCount.Text = "Loading plants...";
            txtSearch.Enabled = false;

            try
            {
                // Load on a background thread so the window doesn't freeze
                _allPlants = await Task.Run(() => PlantRepository.LoadAsync());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load plants.\n\n{ex.Message}");
                return;
            }

            txtSearch.Enabled = true;
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string text = txtSearch.Text.Trim();

            var matches = _allPlants
                .Where(p => text.Length == 0
                         || p.DisplayName.Contains(text, StringComparison.OrdinalIgnoreCase)
                         || p.ScientificName.Contains(text, StringComparison.OrdinalIgnoreCase))
                .ToList();

            lblCount.Text = matches.Count > MaxShown
                ? $"Showing first {MaxShown:N0} of {matches.Count:N0} plants. Type to narrow the list."
                : $"{matches.Count:N0} plants";

            lstPlants.DataSource = matches.Take(MaxShown).ToList();
        }

        private void dtpPlanting_ValueChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void UpdateResult()
        {
            if (lstPlants.SelectedItem is not Plant plant) return;

            string from = plant.MaturityFrom == "transplant" ? "transplanting" : "sowing";
            DateTime expected = dtpPlanting.Value.Date.AddDays(plant.DaysToMaturityAverage);

            lblResult.Text = $"Expected harvest: {expected:MMM dd, yyyy}  ({plant.DaysRange} days from {from})";
            txtDirections.Text = plant.Directions;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
