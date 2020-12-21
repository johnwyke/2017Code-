#include <iostream>
#include <string>

using std::cin;
using std::cout;
using std::endl;
using std::string;//structs are common to   communicate that this data structure//ONLY has data members
template <typename T>
struct Node { 
	T  data{}; 
	Node *  link{ nullptr }; 
};
template <typename T>class LinkedList {
public:
	~LinkedList();  //TODO: Fix this.
	void insertLast(const T&   item);
	void insertFirst(const T&   item);
	void deleteFirst();
	void deleteLast();
	unsigned int size() const { return count; }
private:
	Node<T> *  first{ nullptr };
	Node<T> *  last{ nullptr };
	unsigned int count{ 0 };
};

template <typename T>
LinkedList<T>::~LinkedList() {
	while (first != nullptr) {
		Node<T> * temp = first; 
		first = first->link;
		delete temp; 

	}// end Loop 
}
template <typename T>
void LinkedList<T>::insertLast(const T&   item) {
	
	//******************************
	//WHAT ARE ALL MY   SCENARIOS!?!?!
	//******************************
	if (first == nullptr) {//Scenario #1   - The list is   
		first = new Node<T>;
		first->data = item;
		last = first;
		count++; 
		return;
	}else {
		//Scenario #2   -  The list has at least one item
		Node<T> * tempPtr = new Node<T>();
		tempPtr->data = item;
		 
		last->link = tempPtr;
		last = tempPtr;
		count++;


	}
}
template<typename T>

void LinkedList<T>::insertFirst(const T& item) {
	//Scenario #1   - The list is 
	if (!first) {
		first = new Node<T>();
		first->data = item;
		last = first; 

		count++;

	}else {
	//Scenario #2   -  The list has at least one item
		Node<T> * tempPtr = new Node<T>();
		first->data = item;
		tempPtr->link = first;
		first = tempPtr;
		count++;

}

}
template <typename T>
void LinkedList<T>::deleteFirst() {
	// empty list 
	if (first == nullptr) {
		cout << "list is already empty" << endl;
		return;
	}

	//Node<T>* tempPtr = new Node<T>()// Wrong this did not work 
	Node<T> * tempPtr{ nullptr };
	tempPtr = first;
	first = first->link;
	if (first == nullptr) {
		// there must have been one node 
		last = nullptr;
	}
	delete tempPtr;
	tempPtr = nullptr;

	count--;

}

template <typename T>
void LinkedList<T>::deleteLast() {

	if (first == nullptr) {
		//0 Node scenairo
		// empty list 

		cout << "The list is empty "<< endl;
	}
	else if (first == last) {
		//1 Node scenairo
		delete last; 
		// ********** why do you not delete first???******
		first = nullptr;
		last = nullptr;
		count--;
	}
	else {

		// 2 Node scenarior
		Node<T>*currPtr{ nullptr };
		currPtr = first;
		while (currPtr->link != last) {
			currPtr = currPtr->link;
		}
		// curr is now at the second to last node
		delete last;

		last = currPtr;
		last->link = nullptr;
		count--;
	}
}
}

int main() {

	LinkedList<string> pets;
	pets.insertLast("Jasper"); 
	pets.insertLast("Skeletor"); 
	pets.insertLast("Chikita"); 
	pets.insertLast("Lloyd"); 
	pets.insertLast("FSBO"); 
	pets.insertLast("Zoloft"); 

	pets.deleteLast();
	pets.deleteLast();
	pets.deleteLast();
	pets.deleteLast();
	pets.deleteLast();
	pets.deleteLast();
	pets.deleteLast();
	
	cin.get(); 
	
	return 0;
}