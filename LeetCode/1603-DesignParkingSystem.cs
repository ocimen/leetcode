//Problem: https://leetcode.com/problems/design-parking-system/
namespace LeetCode {
    public class ParkingSystem {
    
        public int Big {get;set;}
        public int Medium {get;set;}
        public int Small {get;set;}
        
        public ParkingSystem(int big, int medium, int small) {
            Big = big;
            Medium = medium;
            Small = small;
        }
        
        public bool AddCar(int carType) {
                if(carType == 1) {
                    return Big-- > 0;
                }
                else if(carType == 2) {                
                    return Medium-- > 0;
                }
                else if(carType == 3) {
                    return Small-- > 0;
                }
                return false;
            
        }
    }
}