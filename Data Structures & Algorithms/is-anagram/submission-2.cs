public class Solution {
    public bool IsAnagram(string s, string t) {
        var charToOccurance = new Dictionary<char,int>();

        foreach(var charac in s){
            if(charToOccurance.ContainsKey(charac)){
                charToOccurance[charac] = charToOccurance[charac] + 1;
            }else{
                charToOccurance.Add(charac, 1);
            }
        }

        var charToOccuranceSecond = new Dictionary<char,int>();

        foreach(var charac in t){
            if(charToOccuranceSecond.ContainsKey(charac)){
                charToOccuranceSecond[charac] = charToOccuranceSecond[charac] + 1;
            }else{
                charToOccuranceSecond.Add(charac, 1);
            }
        }

        foreach(var kvp in charToOccurance){
            if(!charToOccuranceSecond.ContainsKey(kvp.Key) || charToOccuranceSecond[kvp.Key] != kvp.Value){
                return false;
            }
        }

        foreach(var kvp in charToOccuranceSecond){
            if(!charToOccurance.ContainsKey(kvp.Key) || charToOccurance[kvp.Key] != kvp.Value){
                return false;
            }
        }

        return true;
    }
}
