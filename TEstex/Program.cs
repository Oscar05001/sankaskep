string[,] spel1= new string[,] {{"-","-","-","-"},
                                {"-","-","-","-"}, 
                                {"-","-","-","-"},
                                {"-","-","-","-"}}; 

string[,] spel2= new string[,] {{"-","-","-","-"},
                                {"-","-","-","-"}, 
                                {"-","-","-","-"},
                                {"-","-","-","-"}}; 

string[,] spelplan1= new string[,] {{"-","-","-","-"},
                                {"-","-","-","-"}, 
                                {"-","-","-","-"},
                                {"-","-","-","-"}}; 

string[,] spelplan2= new string[,] {{"-","-","-","-"},
                                {"-","-","-","-"}, 
                                {"-","-","-","-"},
                                {"-","-","-","-"}}; 



int speltur = 1;   
bool klar = false;
int X = 0;
int Y = 0;
int hurspelare = 0;

Console.Clear();
Console.WriteLine("Hur många spelare? (en eller två)");
do
{
hurspelare = int.Parse(Console.ReadLine());
} while(hurspelare<0 && hurspelare>2);
Console.Clear();




int skep = 1;
Console.Clear();
Console.WriteLine("Hur många skep ska ni spela med?");
do
{
skep = int.Parse(Console.ReadLine());
} while(skep<0 && skep>16);
Console.Clear();
int liv1 = skep;
int liv2 = skep;

//väljer spelplan med dator
if(hurspelare==1){
//spelar 1 väljer
for(int re=0;re<skep; ++re)
{
Console.WriteLine("1  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spelplan1[0,0]+"|  |"+ spelplan1[0,1]+"|  |"+ spelplan1[0,2]+"|  |"+ spelplan1[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spelplan1[1,0]+"|  |"+ spelplan1[1,1]+"|  |"+ spelplan1[1,2]+"|  |"+ spelplan1[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spelplan1[2,0]+"|  |"+ spelplan1[2,1]+"|  |"+ spelplan1[2,2]+"|  |"+ spelplan1[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spelplan1[3,0]+"|  |"+ spelplan1[3,1]+"|  |"+ spelplan1[3,2]+"|  |"+ spelplan1[3,3]+"|");

Console.WriteLine("Skriv X Kordinat:");
do
{
X = int.Parse(Console.ReadLine());
} while(X>4);

Console.WriteLine("Skriv Y Kordinat:");
do
{
Y = int.Parse(Console.ReadLine());
} while(Y>4);

if(spelplan1[Y-1,X-1]!="X")
{
spelplan1[Y-1,X-1] ="X";
Console.Clear();
}
else
{
Console.Clear();
Console.WriteLine("Är redan taget.");
}

}

Console.WriteLine("Nästa spelare ska välja!");
Console.ReadLine();
Console.Clear();



//Spelare 2/dator väljer plan
for(int re=0;re<skep;)
{

    //X kordinaterna 
    Random rd = new Random();
    X = rd.Next(0,4);

    //Y kordinaterna 
    Random rad = new Random();
    Y = rad.Next(0,4);
    
    if(spelplan2[Y,X]!="X")
    {
        spelplan2[Y,X] ="X";
        re = re+1;
    }
    else
    {
    }

}

}


//två spelare Väljer plan
if(hurspelare==2){
Console.Clear();
//Spelare 1 välje plan
for(int re=0;re<skep; ++re)
{
Console.WriteLine("1  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spelplan1[0,0]+"|  |"+ spelplan1[0,1]+"|  |"+ spelplan1[0,2]+"|  |"+ spelplan1[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spelplan1[1,0]+"|  |"+ spelplan1[1,1]+"|  |"+ spelplan1[1,2]+"|  |"+ spelplan1[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spelplan1[2,0]+"|  |"+ spelplan1[2,1]+"|  |"+ spelplan1[2,2]+"|  |"+ spelplan1[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spelplan1[3,0]+"|  |"+ spelplan1[3,1]+"|  |"+ spelplan1[3,2]+"|  |"+ spelplan1[3,3]+"|");

Console.WriteLine("Skriv X Kordinat:");
do
{
X = int.Parse(Console.ReadLine());
} while(X>4);

Console.WriteLine("Skriv Y Kordinat:");
do
{
Y = int.Parse(Console.ReadLine());
} while(Y>4);

if(spelplan1[Y-1,X-1]!="X")
{
spelplan1[Y-1,X-1] ="X";
Console.Clear();
}
else
{
Console.Clear();
Console.WriteLine("Är redan taget.");
}

}
Console.WriteLine("Nästa spelare ska välja!");
Console.ReadLine();
Console.Clear();

//Spelare 2 väljer plan
for(int re=0;re<skep; ++re)
{
Console.WriteLine("2  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spelplan2[0,0]+"|  |"+ spelplan2[0,1]+"|  |"+ spelplan2[0,2]+"|  |"+ spelplan2[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spelplan2[1,0]+"|  |"+ spelplan2[1,1]+"|  |"+ spelplan2[1,2]+"|  |"+ spelplan2[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spelplan2[2,0]+"|  |"+ spelplan2[2,1]+"|  |"+ spelplan2[2,2]+"|  |"+ spelplan2[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spelplan2[3,0]+"|  |"+ spelplan2[3,1]+"|  |"+ spelplan2[3,2]+"|  |"+ spelplan2[3,3]+"|");

Console.WriteLine("Skriv X Kordinat:");
do //X kordinaterna 
{
X = int.Parse(Console.ReadLine());
} while(X>4);

Console.WriteLine("Skriv Y Kordinat:");
do //Y kordinaterna 
{
Y = int.Parse(Console.ReadLine());
} while(Y>4);

if(spelplan2[Y-1,X-1]!="X")
{
spelplan2[Y-1,X-1] ="X";
Console.Clear();
}
else
{
Console.Clear();
Console.WriteLine("Är redan taget.");
}
}

}
Console.Clear();
Console.WriteLine("Press enter to start!");
Console.ReadLine();
Console.Clear();


// Spel kör
while(liv1>0 || liv2>0)
{

        if(speltur==1) // Spelare 1 tur
        {
            for(int re=0;re==0;)
            {   //Vissar var splare 1 ska välja
                Console.Clear();
                Console.WriteLine("Det finns " +liv1+" kvar!");
                Console.WriteLine("1  X| [1]  [2]  [3]  [4]");
                Console.WriteLine("_Y__|___________________");
                Console.WriteLine("[1] | |"+ spel1[0,0]+"|  |"+ spel1[0,1]+"|  |"+ spel1[0,2]+"|  |"+ spel1[0,3]+"|");
                Console.WriteLine("    |-------------------");
                Console.WriteLine("[2] | |"+ spel1[1,0]+"|  |"+ spel1[1,1]+"|  |"+ spel1[1,2]+"|  |"+ spel1[1,3]+"|");
                Console.WriteLine("    |-------------------");
                Console.WriteLine("[3] | |"+ spel1[2,0]+"|  |"+ spel1[2,1]+"|  |"+ spel1[2,2]+"|  |"+ spel1[2,3]+"|");
                Console.WriteLine("    |-------------------");
                Console.WriteLine("[4] | |"+ spel1[3,0]+"|  |"+ spel1[3,1]+"|  |"+ spel1[3,2]+"|  |"+ spel1[3,3]+"|");

                Console.WriteLine("Skriv X Kordinat:");
                do //X kordinaterna 
                {
                X = int.Parse(Console.ReadLine());
                } while(X>4);
                
                Console.WriteLine("Skriv Y Kordinat:");
                do //Y kordinaterna 
                {
                Y = int.Parse(Console.ReadLine());
                } while(Y>4);
                
                //tittar ifal ett skep är där
                if(spel1[Y-1,X-1]!="X" && spel1[Y-1,X-1]!="O" && spelplan2[Y-1,X-1]=="X")
                {
                    spel1[Y-1,X-1] ="X";
                    liv1 = liv1 - 1;
                    Console.Clear();
                    Console.WriteLine("Träff!");
                    re = re+1;
                    break;            
                }
                else if(spel1[Y-1,X-1]!="X" && spel1[Y-1,X-1]!="O" && spelplan2[Y-1,X-1]=="-" )
                {
                    spel1[Y-1,X-1] ="O";
                    
                    Console.Clear();
                    Console.WriteLine("Miss!");
                    re = re+1;
                    break;   
                }
                else
                {
                Console.WriteLine("Redan tagen");
                }
            }
        if(liv1==0)
        break;
        if(liv2==0)
        break;

        //Vissar resultar för spelar 1
        Console.WriteLine("Det finns " +liv1+" kvar!");
        Console.WriteLine("1  X| [1]  [2]  [3]  [4]");
        Console.WriteLine("_Y__|___________________");
        Console.WriteLine("[1] | |"+ spel1[0,0]+"|  |"+ spel1[0,1]+"|  |"+ spel1[0,2]+"|  |"+ spel1[0,3]+"|");
        Console.WriteLine("    |-------------------");
        Console.WriteLine("[2] | |"+ spel1[1,0]+"|  |"+ spel1[1,1]+"|  |"+ spel1[1,2]+"|  |"+ spel1[1,3]+"|");
        Console.WriteLine("    |-------------------");
        Console.WriteLine("[3] | |"+ spel1[2,0]+"|  |"+ spel1[2,1]+"|  |"+ spel1[2,2]+"|  |"+ spel1[2,3]+"|");
        Console.WriteLine("    |-------------------");
        Console.WriteLine("[4] | |"+ spel1[3,0]+"|  |"+ spel1[3,1]+"|  |"+ spel1[3,2]+"|  |"+ spel1[3,3]+"|");
        Console.WriteLine("Press enter");
        Console.ReadLine();

        if(liv2>0)
        speltur = 2;
        }

        if(speltur==2) // Spelare 2 tur /dator
        {

            if(hurspelare == 2) //spelare 2 väljer
            {  
                for(int re=0;re==0;)
                {   //Vissar var splare 2 ska välja
                    Console.Clear();
                    Console.WriteLine("Det finns " +liv2+" kvar!");
                    Console.WriteLine("2  X| [1]  [2]  [3]  [4]");
                    Console.WriteLine("_Y__|___________________");
                    Console.WriteLine("[1] | |"+ spel2[0,0]+"|  |"+ spel2[0,1]+"|  |"+ spel2[0,2]+"|  |"+ spel2[0,3]+"|");
                    Console.WriteLine("    |-------------------");
                    Console.WriteLine("[2] | |"+ spel2[1,0]+"|  |"+ spel2[1,1]+"|  |"+ spel2[1,2]+"|  |"+ spel2[1,3]+"|");
                    Console.WriteLine("    |-------------------");
                    Console.WriteLine("[3] | |"+ spel2[2,0]+"|  |"+ spel2[2,1]+"|  |"+ spel2[2,2]+"|  |"+ spel2[2,3]+"|");
                    Console.WriteLine("    |-------------------");
                    Console.WriteLine("[4] | |"+ spel2[3,0]+"|  |"+ spel2[3,1]+"|  |"+ spel2[3,2]+"|  |"+ spel2[3,3]+"|");


                    Console.WriteLine("Skriv X Kordinat:");
                    do //X kordinaterna 
                    {
                        X = int.Parse(Console.ReadLine());
                    } while(X>4);

                    Console.WriteLine("Skriv Y Kordinat:");
                    do //Y kordinaterna 
                    {
                        Y = int.Parse(Console.ReadLine());
                    } while(Y>4);

                    //tittar ifal ett skep är där
                    if(spel2[Y-1,X-1]!="X" && spel2[Y-1,X-1]!="O" && spelplan1[Y-1,X-1]=="X")
                    {
                        spel2[Y-1,X-1] ="X";
                        liv2 = liv2 - 1;
                        Console.Clear();
                        Console.WriteLine("Träff!");
                        re = re+1;
                        break;
                        
                    }

                    else if(spel2[Y-1,X-1]!="X" && spel2[Y-1,X-1]!="O" && spelplan1[Y-1,X-1]=="-" )
                    {
                        spel2[Y-1,X-1] ="O";
                        Console.Clear();
                        Console.WriteLine("Miss!");
                        re = re+1;
                        break;
                        
                        
                    
                    }
                    else
                    {
                    Console.WriteLine("Redan tagen");
                    }
                }
            }

            if(hurspelare == 1)//spelare 2 dator väljer
            {
                for(int re=0;re==0;)
                {            
                    do
                    {
                        Random radd = new Random();
                        X = radd.Next(0,3);
                    } while(X>4);

                    do
                    {
                        Random radd = new Random();
                        Y = radd.Next(0,3);
                    } while(Y>4);

                    if(spel2[Y,X]!="X" && spel2[Y,X]!="O" && spelplan1[Y,X]=="X")
                    {
                        spel2[Y,X] ="X";
                        liv2 = liv2 - 1;
                        Console.Clear();
                        Console.WriteLine("Träff!");
                            
                        re = re + 1;
                        break;
                    }

                    else if(spel2[Y,X]!="X" && spel2[Y,X]!="O" && spelplan1[Y,X]=="-" )
                    {
                        spel2[Y,X] ="O";
                        Console.Clear();
                        Console.WriteLine("Miss!");

                        re = re + 1;
                        break;
                    }
                    else
                    {
                    }

                }

            }
            


            if(liv1==0)
            break;
            if(liv2==0)
            break;

            //Vissar resultar för spelar 2
            Console.WriteLine("Det finns " +liv2+" kvar!");
            Console.WriteLine("2  X| [1]  [2]  [3]  [4]");
            Console.WriteLine("_Y__|___________________");
            Console.WriteLine("[1] | |"+ spel2[0,0]+"|  |"+ spel2[0,1]+"|  |"+ spel2[0,2]+"|  |"+ spel2[0,3]+"|");
            Console.WriteLine("    |-------------------");
            Console.WriteLine("[2] | |"+ spel2[1,0]+"|  |"+ spel2[1,1]+"|  |"+ spel2[1,2]+"|  |"+ spel2[1,3]+"|");
            Console.WriteLine("    |-------------------");
            Console.WriteLine("[3] | |"+ spel2[2,0]+"|  |"+ spel2[2,1]+"|  |"+ spel2[2,2]+"|  |"+ spel2[2,3]+"|");
            Console.WriteLine("    |-------------------");
            Console.WriteLine("[4] | |"+ spel2[3,0]+"|  |"+ spel2[3,1]+"|  |"+ spel2[3,2]+"|  |"+ spel2[3,3]+"|");
            Console.WriteLine("Press enter");
            Console.ReadLine();

            if(liv1>0)
            speltur = 1;
        
        }
    Console.Clear();
}
if(liv1==0)
    Console.WriteLine("Gratis spelare 1 du van!");

if(liv2==0)
    Console.WriteLine("Gratis spelare 2 du van!");








