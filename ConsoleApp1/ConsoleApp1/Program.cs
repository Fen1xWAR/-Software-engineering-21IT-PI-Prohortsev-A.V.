namespace MyUnits
{
    public abstract class UnitBase
    {
        public int Speed { get; set; }
        public string MainWeapon { get; set; }
    }

    public abstract class HumanBase : UnitBase
    {
        public int Health { get; set; }
        
    }

    public class Infantry : HumanBase
    {
        public int SecondaryWeapon { get; set; }
    }

    interface ISecondaryWeapon
    {
        public string SecondaryWeapon  { get; set; } 
    }

    public class MachineGunTeam : HumanBase, ISecondaryWeapon
    {
        public string SecondaryWeapon { get; set; }
    }

    public abstract class Vehicle : UnitBase
    {
        public int FuelCapacity { get; set; }
    }

    public class Tank : Vehicle, ISecondaryWeapon
    {
        public string SecondaryWeapon { get; set; }
    }

    public class Howitzer : Vehicle
    {
        public int AttackRange { get; set; }
    }
    public abstract class FlyingVehicle : Vehicle
    {
        public int DetectionRange { get; set; }
    }

    public class Aircraft : FlyingVehicle
    {
        
    }

    public class Helicopter : FlyingVehicle
    {
        public int TroopsCount { get; set; }
    }
}
// public List<Infantry> infantryList = new List<Infantry>(); 
    //
    // public void addUnit(Infantry infantry) 
    // { 
    //     infantryList.Add(infantry); 
    // } 
    //
    // public void removeUnit(Infantry infantry) 
    // { 
    //     infantryList.Remove(infantry); 
    // } 
    // }

    
    // public class Infantry : Unit 
    // { 
    //     public string PersonalWeapon { get; set; } 
    // } 
    //
    // public class Infantryman : Infantry 
    // { 
    //
    // } 
    //
    // public class MachineGunTeam : Infantry 
    // { 
    //
    // } 

//     public class Vehicle : Unit 
//     { 
//         public int PassengerCapacity { get; set; } 
//         private List<Unit> unitList = new List<Unit>(); 
//
//         public void addVehicle(Unit unit) 
//         { 
//             unitList.Add(unit); 
//         } 
//
//         public void removeVehicle(Unit unit) 
//         { 
//             unitList.Remove(unit); 
//         } 
//     } 
//
//     public class Tank : Vehicle 
//     { 
//
//     } 
//
//     public class Aircraft : Vehicle 
//     { 
//
//     } 
//
//     public class Helicopter : Vehicle 
//     { 
//
//     } 
//
//     public class Howitzer : Vehicle 
//     { 
//
//     } 
// }