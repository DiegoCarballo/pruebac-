namespace Prueba_1.Model
{
    public class User
    {
        public string Name { get;set;}
        public int Age {get;set;}
        public int UserID{get;set;}

        //Metodos

        public string diceHola(){
            return $"Hola, mi nombre es {Name}";

        }
         public bool miEdad(){
            return Age>21 ;
            
        }

        public User(string nombre, int edad, int ide){
            Name = nombre;
            Age = edad;
            UserID = ide;

        }


    }
}