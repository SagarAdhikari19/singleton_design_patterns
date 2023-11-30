

    public sealed class Practice
    {//sealed keyword is used to prevent class being inherited


        private static int counter=0;
        //counter will be increment by 1 when the obj of the class is created 


        private static Practice Instancee =null;
        //static: This keyword means that the variable belongs to the class itself, rather than to instances of the class. 
        //There is only one copy of this variable shared by all instances of the class.

        public static Practice get_the_instance(){
            //

            if(Instancee==null){
                Instancee=new Practice();
            }


            return Instancee;
        }

        private Practice(){


            counter++;
            Console.WriteLine("countervalue "+ counter.ToString());
        }

        public void To_print(string message){
            Console.WriteLine(message);
        }

    }

