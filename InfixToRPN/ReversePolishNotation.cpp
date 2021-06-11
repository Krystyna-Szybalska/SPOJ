/*Your task is to transform the expression with brackets into RPN form.
Priority: + -  <  * /  <  ^  < ( )
Input
The first line of the standard input contains one integer t (t<101) which is the number of test cases.
In each of the next t lines there is a string consisted of two-argument operators: +, -, *, /, ^, brackets ( ) and letters a-z (operands).

Output
For each test case print the expression in RPN form.

Example
Input:  ==>  output
4
(a+(b*c))  ==>  abc*+
((a+b)*(z+x))  ==>  ab+zx+*
((a+t)*((b+(a+c))^(c+d)))  ==>  at+bac++cd+^*
((a-g)^l/c^h*(l^f-g^y)^i^j)  ==>  ag-l^ch^/lf^gy^-i^j^*

Notice
I made a mistake and exponentation in the task is left-associative while it should be right-associative.*/

#include <iostream>
#include <stack>

using namespace std;

int main () {
    int testCases;
    string inputString;
    cin >> testCases;
    while(testCases--){
        cin >> inputString;
        string outputString;
        stack <char> operatorStack;
        for (int i = 0; i < inputString.size(); i++){
            if (inputString[i] == '+' || inputString[i] == '-'){
                while (!operatorStack.empty() && (operatorStack.top() == '^' || operatorStack.top() == '*' || operatorStack.top() == '/' || operatorStack.top() == '+' || operatorStack.top() == '-'))
                {
                    outputString += operatorStack.top();
                    operatorStack.pop();
                }
                operatorStack.push(inputString[i]);
            }
            else if(inputString[i] == '*' || inputString[i] == '/'){
                while (!operatorStack.empty() && (operatorStack.top() == '^' || operatorStack.top() == '*' || operatorStack.top() == '/'))
                {
                    outputString += operatorStack.top();
                    operatorStack.pop();
                }
                operatorStack.push(inputString[i]);
            }

            else if(inputString[i] == '^'){
                if (!operatorStack.empty() && (operatorStack.top() == '^')) {
                     outputString += operatorStack.top();
                    operatorStack.pop();
                }
                operatorStack.push(inputString[i]);
            }

            else if(inputString[i] == '('){
                operatorStack.push(inputString[i]);
            }
            else if(inputString[i] == ')'){
                while (operatorStack.top() != '(')
                {
                    outputString += operatorStack.top();
                    operatorStack.pop();
                }
                operatorStack.pop();
            }
            else{
                outputString += inputString[i];
            }
        }
        while(!operatorStack.empty()){
            outputString += operatorStack.top();
            operatorStack.pop();
        }
        cout << outputString << "\n";
    }
    return 0;
}