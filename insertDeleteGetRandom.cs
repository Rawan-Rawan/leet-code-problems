public class RandomizedSet {
    private Dictionary<int, int> dictionary;
    private List<int> list;
    private Random random;

    public RandomizedSet() {
        dictionary = new Dictionary<int, int>();
        list = new List<int>();
        random = new Random();
    }
    
    public bool Insert(int val) {
        if (dictionary.ContainsKey(val)) return false;
        dictionary[val] = list.Count;
        list.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if (!dictionary.ContainsKey(val)) return false;
        
        int index = dictionary[val];
        int lastElement = list[list.Count - 1];
        list[index] = lastElement;
        dictionary[lastElement] = index;

        list.RemoveAt(list.Count - 1);
        dictionary.Remove(val);

        return true;
    }
    
    public int GetRandom() {
        int randomIndex = random.Next(list.Count);
        return list[randomIndex];
    }
}


