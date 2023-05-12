using UnityEngine;

namespace MyPlayer
{
    public class Sample02 : MonoBehaviour
    {
        public int currentAge = 30;
        public int addedAge = 1;
        public float Pi = 3.14f;
        public string firstName = "Harrison";
        public bool isAuthor = true;

        private void Start()
        {
            //実装中を意味する -> 完了する場合はコメントしてください
            //throw new NotImplementedException();
            
            //body
            //Debug.Log($"文字列には{firstName}のような変数を挿入できる");

            var characterLevel = 32;

            OutputCharacterLevel(GenerateCharacter("Spike", characterLevel));
        }

        private int GenerateCharacter(string name, int level)
        {
            Debug.LogFormat("Character: {0} - Level: {1}", name, level);
            return level + 5;
        }

        private void OutputCharacterLevel(int level)
        {
            Debug.Log($"After Level:{level}");
        }
        
    }
}