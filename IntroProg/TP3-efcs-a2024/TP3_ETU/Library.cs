namespace TP3_ETU
{
    public class Library
    {
        public static void InsertClan(List<Clan> p_allClans, Clan p_clan)
        {
            if (p_allClans == null || p_clan == null)
            {
                throw new ArgumentException("clan cannot be null");
            }

            p_allClans.Add(p_clan);
        }
        public static void RemoveClan(List<Clan> p_allClans, int p_index)
        {
            if (p_allClans == null)
            {
                throw new ArgumentException("List cannot be null");
            }
            if (p_allClans == null || p_index < 0 || p_index >= p_allClans.Count)
            {
                throw new ArgumentException("Invalid clan number");
            }

            p_allClans.RemoveAt(p_index);
        }
        public static void UpdateClan(List<Clan> p_allClans, int p_index, Clan p_updatedClan)
        {
            if (p_index < 0 || p_index >= p_allClans.Count)
            {
                throw new ArgumentException("Invalid clan number");
            }
            if (p_allClans == null)
            {
                throw new ArgumentException("List cannot be null");
            }

            if (p_updatedClan == null)
            {
                throw new ArgumentException("clan cannot be null");
            }

            p_allClans[p_index] = p_updatedClan;
        }
    }
}
