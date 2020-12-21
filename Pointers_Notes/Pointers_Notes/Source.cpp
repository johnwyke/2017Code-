#include <iostream>

using std::cout;
using std::cin;
using std::endl;

template <typename T> // This allows for dat type to be determined later
class SafeArray {
public:
	SafeArray(const unsigned int size);
	~SafeArray();

	void insert(const unsigned int index, const T& item);
	T get(const unsigned int index)const; // the second const means the method cant change data members. 
	unsigned int size() const {return capacity;}

private: 
	T * arr{ nullptr };
	unsigned int capacity{ 0 };
};

template <typename T>
SafeArray<T>::SafeArray(const unsigned int size) {
	this->capacity = size;
	// this is a very important line of code.
	// do not want to redeclare a ptr in the constructor it iwll live and die in there
	arr = new T[capacity];
}
// Destructor cleans up anything that constructor makes 
template <typename T>
SafeArray<T>::~SafeArray() {
	delete[] arr;

}
template <typename T>
void SafeArray<T>::insert(const unsigned int index, const T& item) {
	if (index > capacity) {
		cout << "Index" << index << "is out of bounds" << endl;
		return;
	}
	arr[index] = item;
}
template <typename T>
T SafeArray<T>::get(const unsigned int index)const {
	if (index > capacity) {
		cout << "Index" << index << "is out of bounds" << endl;
		// You do not return  commonly crash program 
		// however we are using throw an error
		throw 1;
	}
	return arr[index];
}

// if you see *, what does it mean? 
// declraing a pointer
//Derefercning
//Multiplying

//if you see a &, what does it mean? 
// address of 
// pass by refernce 
// Bitwise & 
int main() {

	// TTHis is the start of the first day. 

	cout << "Hi" << endl;
	
	int val{ 42 };

	int * ptr = &val; //& means addres of 
	cout << "the values is " << val << "at address: " << ptr << endl;
	cout << "I can also get to the value this way: " << *ptr << endl;
	int myArr[100];// takes up 400 bytes becasue a int is 4 bytes

	
	cin.get();
	return 0;
//// THis is the beginning of the second day. 
//// Construct the Array
//
//// int myArr[1000000];
//
//	int * myArr = new int[10000000];
//
//	cout << " The data at the first element is: " << * myArr << endl;
//
//	// Pointer arithmatic  is myArr++ 
//
//	//myArr++;
//	//cout << " The data at the second element is: " << *myArr << endl;
//
//	*(myArr + 1) = 42; 
//	cout << " The data at the Second element is: " << *(myArr +1) << endl;
//
//	//[] means do arithmatic then dereference it. 
//	cout << " The data at the first element is: " << * myArr[1] << endl;
//
//	// if you allocate with[] you must delete with []
//	// this is how you tell the OS that you are finished with the memory. 
//	delete[] myArr;
//	myArr = nullptr;
	// Templates are nothing more than find and replace. 
	/*SafeArray<int> myArr(100);
	myArr.insert(0, 42);
	myArr.insert(1, 55);
	myArr.insert(-1, 666);
	myArr.insert(100, 666);
	cout << "Data at index 1 is: " << myArr.get(1)<<endl;
	try {
		cout << "the data at index 666" << myArr.get(666) << endl;
	}
	catch (int error) {
		cout << "Caught an error!" << endl;
	}
	cout << "The array has this many times: " << myArr.size() << endl;

*/

	}