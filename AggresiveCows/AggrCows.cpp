/*Farmer John has built a new long barn, with N (2 <= N <= 100,000) stalls. The stalls are located along a straight line at positions x1,...,xN (0 <= xi <= 1,000,000,000).

His C (2 <= C <= N) cows don't like this barn layout and become aggressive towards each other once put into a stall. 
To prevent the cows from hurting each other, FJ wants to assign the cows to the stalls, such that the minimum distance between any two of them is as large as possible. 
What is the largest minimum distance?

Input
t – the number of test cases, then t test cases follows.
* Line 1: Two space-separated integers: N and C
* Lines 2..N+1: Line i+1 contains an integer stall location, xi

Output
For each test case output one integer: the largest minimum distance.*/

#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

bool CheckIfThatDistanceIsOkay(vector<int> sortedVect, int numberOfCows, int maxDistance){
    long long sum = sortedVect[0] + maxDistance;
    int maxPossibleNumberOfCows = 1;

    for (int i = 1; i < sortedVect.size(); i++){
        if (sortedVect[i]>=sum) {
            maxPossibleNumberOfCows++;
            sum = sortedVect[i]+ maxDistance;
        }
    }
    if (maxPossibleNumberOfCows < numberOfCows) return false;
    return true;
}

int main () {
    int testCases, stalls, cows, stallLocation, testedDistance;
    cin >> testCases;
    while(testCases--){
        cin >> stalls >> cows;
        vector <int> stallLocations;
        while (stalls--){
            cin >> stallLocation;
            stallLocations.push_back(stallLocation);
        }
        sort(stallLocations.begin(), stallLocations.end());
        int start = 0;
        int end = stallLocations[stallLocations.size()-1] - stallLocations[0];
        while (end-start>=0){
            testedDistance = (start+end)/2;
            bool isItGoingToWorkOut = CheckIfThatDistanceIsOkay(stallLocations, cows, testedDistance);

            if (isItGoingToWorkOut){ start = testedDistance; }
            else{ end = testedDistance; }
                    
            if(end-start <= 1){
                testedDistance = start;
                break;
            }
        }  
        cout << testedDistance << '\n';
    }
}