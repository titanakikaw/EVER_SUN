// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// 1.
// ----------------------------------------------------------
// int x = 4;
// int ctr = 0;
// bool pass = false;
// for (int i = 1; i <= 13; ++i) 
// {
//     for (int j = 1; j <= 7; j++) 
//     {
//        Console.Write(j == x || j == x + ctr ? "*" : "-");
//     }
//     pass = (x == 1) ? true : ((x == 4) ? false : pass);
//     ctr += pass ? -2 : 2;
//     x += pass ? 1 : -1;
//     Console.WriteLine("");
// }
// ----------------------------------------------------------



// 2.
// ----------------------------------------------------------
// int x = 0;
// int k = 10;
// int y = 6;
// bool pass = false;
// for (int i = 0; i <= 10; i++) 
// {
//     for(int j = 11; j >= 0; j--){
//         Console.Write(j == x || j == k ? (j % 2 == 0 ? "*" : y) : " ");
//     }
//     pass = (y == 1) ? true : ((y == 6) ? false : pass);
//     y = (pass == false) ? y - 1 : y + 1;
//     x++;
//     k--;
//     Console.WriteLine("");
// }
// ----------------------------------------------------------



// 3.
// int height = 9;
// int max = 5;
// int min = 1;
// for(int i = 1; i <= height ; i++){
//     for(int j = 1; j <= min; j++ ){
//         Console.Write((min * j) + " ");
//     }
//     if(i >= max){
//         min--;
//     }else{
//         min++;
//     }
    
//     Console.WriteLine("");
// }



// 4.
// int multiple = 2;
// int p = 1;

// for(int i= 1; i <= 6; i++){
//     Console.Write(i + " ");
//     for(int j=1; j <= 4; j++){
//         Console.Write(p * multiple + " ");
//         p = p * multiple;
//     }
//     p = i + 1;
//     multiple += 1;
//     Console.WriteLine("");
// }