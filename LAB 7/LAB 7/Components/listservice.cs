namespace LAB_7.Components
{
   public class listservice
    {
        private List<string> items = new List<string>();
        public List<string> getall()
        { return items; }
        public void add(string item)
        {
            if (!string.IsNullOrWhiteSpace(item))
                items.Add(item);
        }
        public void delete(string item)
        {  items.Remove(item); }
        public void edit(string olditem, string newitem)
        {
            int index = items.IndexOf(olditem);
            if (index != -1)
                items[index] = newitem;
        }
        public List<string> search(string keyword)
        {  return items.Where(x => x.ToLower().Contains(keyword.ToLower())).ToList(); }
    }
}
