//
//  main.cpp
//  Euler
//
//  Created by hpowlows on 21/12/2018.
//  Copyright © 2018 Kaparray. All rights reserved.
//


#include <iostream>
#include <cmath>
#include <sstream>
#include <iostream>
#include <iomanip>

using namespace std;

double func(double x, double y)
{
      return 2.5 * x + cos(y + 0.6);
}
int main()
{
    /* Create variebles in the stack */
    //////////////////////////////////
    int i = 0;
    double x, y, h, k1, k2, k3, k4;
    //////////////////////////////////
    
    x = 1;    y = 1.5;    h = 0.2;
    cout << " ----------------------------------------" << endl;

   cout <<  "|   x[" << i + 1 << "]  = "  << std::setw(5) << x << std::setw(5) << "   |   " << "y[" << i + 1 << "] = " << y << "       |" << endl;
    // loop for output array wityh data
    for (i = 1; i <= 10; i++){
        k1 = h*func(x, y);
        k2 = h*func(x + h / 2, y + k1 / 2);
        k3 = h*func(x + 0.5 * h, y + 0.5 * k2);
        k4 = h*func(x + h, y + k1 - 2 * k2 + 2 * k3);
        x += h;
        y += (k1 + 4 * k3 + k4) / 6;
       if (i < 9)
           cout <<  "|   x[" << i + 1 << "]  = "  << std::setw(5) << x << std::setw(5) << "   |   " << "y[" << i + 1 << "] = " << y;
       else
           cout <<  "|   x[" << i + 1 << "] = "  << std::setw(5) << x << std::setw(5) << "   |   " << "y[" << i + 1 << "] = " << y;
      if (i == 6)
           cout  << "    |" <<  endl;
      else if (i == 10)
           cout  << "  |" <<  endl;
      else
        cout  << "   |" <<  endl;
            
    }
    cout << " ----------------------------------------" << endl;

    cout << endl << endl; // output new line symbol
    
    x = 1.0;    y = 1.5;   h = 0.1; // Refactor variebles
    cout << " -----------------------------------------" << endl;
  cout <<  "|   x[" << 1 << "]  = "  << std::setw(5) << x << std::setw(5) << "   |   " << "y[" << i + 1 << "] = " << y << "       |" << endl;
    for (i = 1; i <= 20; i++){
        k1 = h * func(x, y);
        k2 = h * func(x + h / 2, y + k1 / 2);
        k3 = h * func(x + 0.5 * h, y + 0.5 * k2);
        k4 = h * func(x + h, y + k1 - 2 * k2 + 2 * k3);
        x += h;
        y += (k1 + 4 * k3 + k4) / 6;
        if (i < 9)
            cout <<  "|   x[" << i + 1 << "]  = "  << std::setw(5) << x << std::setw(5) << "   |   " << "y[" << i + 1 << "] = " << y << "    |" << endl;
        else
            cout <<  "|   x[" << i + 1 << "] = "  << std::setw(5) << x << std::setw(5) << "   |   " << "y[" << i + 1 << "] = " << y << "   |" << endl;
        
    }
    cout << " -----------------------------------------" << endl << endl;

    cout << "Inaccuracy = " << (double)((10.8148 - 10.8131)) << endl;
    system("pause"); // Not work in MAC OS X :(
    return 0;
}
