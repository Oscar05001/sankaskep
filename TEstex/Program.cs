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

string i = "2";

int speltur = 1;   
bool klar = false;

int X = 0;
int Y = 0;

int skep = 1;
Console.Clear();
Console.WriteLine("Hur många skep ska ni spela med?");
skep = int.Parse(Console.ReadLine());
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

Console.WriteLine("2  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spelplan2[0,0]+"|  |"+ spelplan2[0,1]+"|  |"+ spelplan2[0,2]+"|  |"+ spelplan2[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spelplan2[1,0]+"|  |"+ spelplan2[1,1]+"|  |"+ spelplan2[1,2]+"|  |"+ spelplan2[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spelplan2[2,0]+"|  |"+ spelplan2[2,1]+"|  |"+ spelplan2[2,2]+"|  |"+ spelplan2[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spelplan2[3,0]+"|  |"+ spelplan2[3,1]+"|  |"+ spelplan2[3,2]+"|  |"+ spelplan2[3,3]+"|");

Console.ReadLine();

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
do
{
X = int.Parse(Console.ReadLine());
} while(X>4);

Console.WriteLine("Skriv Y Kordinat:");
do
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

Console.WriteLine("2  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spelplan2[0,0]+"|  |"+ spelplan2[0,1]+"|  |"+ spelplan2[0,2]+"|  |"+ spelplan2[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spelplan2[1,0]+"|  |"+ spelplan2[1,1]+"|  |"+ spelplan2[1,2]+"|  |"+ spelplan2[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spelplan2[2,0]+"|  |"+ spelplan2[2,1]+"|  |"+ spelplan2[2,2]+"|  |"+ spelplan2[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spelplan2[3,0]+"|  |"+ spelplan2[3,1]+"|  |"+ spelplan2[3,2]+"|  |"+ spelplan2[3,3]+"|");

Console.ReadLine();






// Spel kör
while(!klar)
{

if(speltur==1)
{
Console.Clear();
Console.WriteLine("1  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spel1[0,0]+"|  |"+ spel1[0,1]+"|  |"+ spel1[0,2]+"|  |"+ spel1[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spel1[1,0]+"|  |"+ spel1[1,1]+"|  |"+ spel1[1,2]+"|  |"+ spel1[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spel1[2,0]+"|  |"+ spel1[2,1]+"|  |"+ spel1[2,2]+"|  |"+ spel1[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spel1[3,0]+"|  |"+ spel1[3,1]+"|  |"+ spel1[3,2]+"|  |"+ spel1[3,3]+"|");

Console.ReadLine();
Console.Clear();
Console.WriteLine("Tryck på enter för att nästa spelare ska spela");

i = Console.ReadLine();
if(i=="1")
{
klar=true;
break;
}

speltur = 2;
}

if(speltur==2)
{

Console.Clear();
Console.WriteLine("2  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] |"+ spel2[0,0]+"|  |"+ spel2[0,1]+"|  |"+ spel2[0,2]+"|  |"+ spel2[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] |"+ spel2[1,0]+"|  |"+ spel2[1,1]+"|  |"+ spel2[1,2]+"|  |"+ spel2[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] |"+ spel2[2,0]+"|  |"+ spel2[2,1]+"|  |"+ spel2[2,2]+"|  |"+ spel2[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] |"+ spel2[3,0]+"|  |"+ spel2[3,1]+"|  |"+ spel2[3,2]+"|  |"+ spel2[3,3]+"|");






Console.ReadLine();
Console.Clear();
Console.WriteLine("Tryck på enter för att nästa spelare ska spela");

i = Console.ReadLine();
if(i=="1")
{
klar=true;
break;
}

speltur = 1;
}

}







