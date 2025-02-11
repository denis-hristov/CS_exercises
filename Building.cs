int level = int.Parse(Console.ReadLine());
int apartment = int.Parse(Console.ReadLine());
bool flor = level % 2 == 0;
for (int l = level; l > 0; l--){
	string matrix = "";
	for (int a = 0; a < apartment; a++){
    	if (l == level) matrix += $"L{l}{a} ";
        else if (flor) matrix += $"O{l}{a} ";
        else matrix += $"A{l}{a} ";
	}
	Console.WriteLine(matrix.Trim());
    flor = !flor;
}