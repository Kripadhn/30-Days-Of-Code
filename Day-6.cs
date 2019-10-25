int main() {

    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    string s;
    int t;
    cin >> t;
    for (int a0 = 0; a0 < t; a0++){
        cin >> s;
        printEvenIndexChar(s);
        cout << " ";
        printOddIndexChar(s);
        cout << endl;
    }
    return 0;
}