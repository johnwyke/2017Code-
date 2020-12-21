# include<iostream>
using std::cout;
using std::endl;
using std::cin;

template<typename T>
class Fraction {
public: 
	void print() const;
	Fraction(const T& numerator, const T& denominator);
	Fraction<T> multiply(const Fraction<T>& rightoperand) const;
private:
	// 99% fo the time, data members should be private, by object oriented convention

	T numerator{ 0 };
	T denominator{ 1 };


};

template <typename T>
Fraction<T> Fraction<T>::multiply(const Fraction<T>& rightoperand) const // that const is really reffering to the left operand
{
	Fraction<T> retVal(0, 1);
	
retVal.numerator = this->numerator * rightoperand.numerator;
retVal.denominator = this->denominator * rightoperand.denominator;
	return retVal;
	 
}
template <typename T>
Fraction<T>::Fraction(const T& numerator, const T& denominator) {
	this->numerator = numerator;
	this->denominator = denominator; 
}

template <typename T>
void Fraction<T>::print() const {
	cout << numerator << "/" << denominator << endl;
}

int main() {
	// Notes for the first assignemnt. 
	// T * arr{ nullptr};
	// int capacity {0};

	// A constructor only needs one parameter. 
	// The constructor in the homework needs NEW to create a new array. 
	// make sure that the order is correct write into array first then do ++
	//T courseStack<T>.pop(){currentSize--;	return arr[currentSize]; }
	// IN push Post fix works well. 
	// Throw errors in POP throw 1. 

	// we are now starting the que 
	// logically wrap the array 
	// if current size is 0 needs to be checked at the beginning of the method. 
	// if back == capacity then back is now = to 0 

	Fraction<int> f1(2, 3);
	Fraction<int> f2(2, 3);

	f1.print();
	f2.print();

	Fraction<int> f3 = f1.multiply(f2);

	f3.print();
	// everything on the heap is always apointer
	Fraction<int> *heapfraction = new Fraction<int>(5, 7);
	// (*heapfraction).print();
	//heapfraction->print();
	// anything on the heap needs to be cleaned up 
	//delete heapfraction;
	
	//484950 -- participation code

	cin.get();
}// End main 