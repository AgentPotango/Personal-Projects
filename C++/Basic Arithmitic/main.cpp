#include <iostream>

using namespace std;

int main()
{
    int add_result = 10 + 10; /* gives 20 */
    int sub_result = 9 - 7; /* gives 2 */
    int mult_result = 2 * 6; /* gives 12 */
    int int_division_result = 101 / 2; /* gives 50 */
    int mod_result = 101 % 2; /* gives 1 */

    /* Order of Precedence */

    int precedence_result = 6 * (4 + 8) * 4 + 9 / 20;

    /* Anything in Brackets gets done first
        Then division and multiplication,
        Then Addition and Subtraction,
        (Using Associative properties)*/

    return 0;
}
