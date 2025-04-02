namespace LeetCodeSolutions.Solutions.HashTable.Medium;

public class Insert_Delete_GetRandom_O_1_ {
    
    public class RandomizedSet
    {
        private readonly Dictionary<int, int> _valueIndexMap;
        private readonly List<int> _values;

        public RandomizedSet() {
            _values = [];
            _valueIndexMap = new Dictionary<int, int>();
        }
    
        public bool Insert(int val) {
            if(_valueIndexMap.ContainsKey(val)) 
                return false;

            _values.Add(val);
            _valueIndexMap.Add(val, _values.Count - 1);
            return true;
        }
        
        public int GetRandom() => _values[Random.Shared.Next(_values.Count)];
    
        public bool Remove(int val) {
            if(!_valueIndexMap.TryGetValue(val, out var index)) 
                return false;

            RemoveByIndex(index);
            return true;
        }

        private void RemoveByIndex(int indexToRemove)
        {
            var valueToRemove = _values[indexToRemove];
            var lastIndex = _values.Count - 1;
            var lastValue = _values[lastIndex];

            (_values[indexToRemove], _values[lastIndex]) = (_values[lastIndex], _values[indexToRemove]);

            _valueIndexMap[lastValue] = indexToRemove;
            _valueIndexMap.Remove(valueToRemove);
            _values.RemoveAt(_values.Count - 1);
        }
    }
}