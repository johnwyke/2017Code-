// Copyright 2017, Bradley Peterson, Weber State University, all rights reserved.

#include <iostream>
#include <string>
#include <stack>
#include <sstream>
#include <cmath>
#include <memory>

//To prevent those using g++ from trying to use a library
//they don't have
#ifndef __GNUC__
#include <conio.h>
#else
#include <stdio.h>
#endif

using std::stack;
using std::istringstream;
using std::ostringstream;
using std::string;
using std::cout;
using std::cerr;
using std::endl;
using std::pow;
using std::unique_ptr;

template <typename T>
struct Node {
public:
	T data{};
	unique_ptr < Node<T> > left;
	unique_ptr< Node<T> > right;
};


class TreeParser {
public:
	TreeParser();
	void displayParseTree();
	void processExpression(string &expression);
	string computeAnswer();
	void inOrderTraversal() const;
	void postOrderTraversal() const;
protected:
	string expression;
	int position;
private:
	stack<string> mathStack;
	double castStrToDouble(string const &s);
	string castDoubleToStr(const double d);
	void initialize();
	bool isDigit(char c);
	bool isOperator(char c);
	void processExpression(Node<string> *p);
	void computeAnswer(Node<string> *p);
	void inOrderTraversal(Node<string> *ptr)const;
	void postOrderTraversal(Node<string> *ptr) const;

	unique_ptr<Node<string>> root;

};
//The public one, the one the user can call, the one that gets it all started

bool TreeParser::isOperator(char c) {
	if (c == '+')
		return true;
	else if (c == '-')
		return true;
	else if (c == '*')
		return true;
	else if (c == '/')
		return true;
	else if (c == '^')
		return true;
	else
		return false;
}

bool TreeParser::isDigit(char c) {
	if (c == '0')
		return true;
	else if (c == '1')
		return true;
	else if (c == '2')
		return true;
	else if (c == '3')
		return true;
	else if (c == '4')
		return true;
	else if (c == '5')
		return true;
	else if (c == '6')
		return true;
	else if (c == '7')
		return true;
	else if (c == '8')
		return true;
	else if (c == '9')
		return true;
	else
		return false;
}

//Public One
void TreeParser::processExpression(string &expression) {


	this->expression = expression;
	if (expression == "") {
		cout << "Expression is empty" << endl;
	}
	else {
		
		root = std::make_unique<Node<string>>();
		this->position = 0;
		processExpression(root.get());
	}
		
}
//Private One
void TreeParser::processExpression(Node<string> * p) {
	while (position != expression.size()) {
		if (expression.at(position) == '(') {
			unique_ptr<Node<string> > newNode = std::make_unique< Node<string>>();
			newNode->left = nullptr;
			newNode->right = nullptr;
			p->left = std::move(newNode);
			position++;
			processExpression(p->left.get());

		}
		else if (expression.at(position) == ')') {
			position++;
			return;
		}
		else if (expression.at(position) == ' ') {
			position++;

		}
		else if (isOperator(expression.at(position))){
			p->data = expression.at(position);
			
			unique_ptr<Node<string>> oper = std::make_unique<Node<string>>();
			p->right = std::move(oper);
			position++;
			processExpression(p->right.get());
		}
		else{
			string digit = "";
			while (isDigit(expression.at(position))){
				digit += expression.at(position);
				position++;
			}
			p->data = digit;
			//castStrToDouble(digit);
			//mathStack.push(digit);
			return;
		}
	}
	
}

//Public One
string TreeParser::computeAnswer() {
	string answer = "";
	computeAnswer(root.get());
	answer = mathStack.top();
	mathStack.pop();
	return answer;
}
//private One
void TreeParser::computeAnswer(Node<string> *p) {
	double digitOne = 0;
	double digitTwo = 0;
	double answer = 0;

	if (p != nullptr) {
		computeAnswer(p->left.get());
		computeAnswer(p->right.get());
		if (isDigit(p->data.at(0))){
			mathStack.push(p->data);
		}
		if (isOperator(p->data.at(0))) {
			digitTwo = castStrToDouble(mathStack.top());
			mathStack.pop();
			digitOne = castStrToDouble(mathStack.top());
			mathStack.pop();

			if (p->data.at(0) == '+') {
				//+
				answer = digitOne + digitTwo;
			}
			else if (p->data.at(0) == '-') {
				// -
				answer = digitOne - digitTwo;
			}
			else if (p->data.at(0) == '*') {
				// *
				answer = digitOne * digitTwo;
			}
			else if (p->data.at(0) == '/') {
				// /
				answer = digitOne / digitTwo;
			}
			else {
				answer = pow(digitOne, digitTwo);
			}
			
			mathStack.push(castDoubleToStr(answer));
		}
	}
}


void TreeParser::inOrderTraversal() const {
	inOrderTraversal(root.get());
	cout << endl;
}
//The private one, it accesses pointers, it keeps recursion going

void TreeParser::inOrderTraversal(Node<string> * ptr) const {
	if (ptr) {
		//LVR
		inOrderTraversal(ptr->left.get());   //Left (recursively)
		cout << ptr->data << " "; //Visit
		inOrderTraversal(ptr->right.get());   //Right (recursively)
	}
}
//The public one, the one the user can call, the one that gets it all started


void TreeParser::postOrderTraversal() const {
	postOrderTraversal(root.get());
	cout << endl;
}
//The private one, it accesses pointers, it keeps recursion going

void TreeParser::postOrderTraversal(Node<string> * ptr) const {
	if (ptr) {
		//LRV
		postOrderTraversal(ptr->left.get());   //Left (recursively)
		postOrderTraversal(ptr->right.get());   //Right (recursively)
		cout << ptr->data << " "; //Visit
	}
}


void TreeParser::initialize() {
	expression = "";
	position = 0;
	while (!mathStack.empty()) {
		mathStack.pop();
	}

}

double TreeParser::castStrToDouble(const string &s) {
	istringstream iss(s);
	double x;
	iss >> x;
	return x;
} 

string TreeParser::castDoubleToStr(const double d) {
	ostringstream oss;
	oss << d;
	return oss.str();

} 

TreeParser::TreeParser() {
	initialize();
}


void TreeParser::displayParseTree() {
	cout << "The expression seen using in-order traversal: "; 
	inOrderTraversal();
	cout << endl;
	cout << "The expression seen using post-order traversal: "; 
	postOrderTraversal();
	cout << endl;
	
}

void pressAnyKeyToContinue() {
	printf("Press any key to continue\n");

	//Linux and Mac users with g++ don't need this
	//But everyone else will see this message.
#ifndef __GNUC__
	_getch();
#else
	int c;
	fflush(stdout);
	do c = getchar(); while ((c != '\n') && (c != EOF));
#endif

}


int main() {
	TreeParser *tp = new TreeParser;
	
	string expression = "(4+7)";
	tp->processExpression(expression);
	tp->displayParseTree();
	cout << "The result is: " << tp->computeAnswer() << endl; //Should display 11 as a double output
	
	expression = "(7-4)";
	tp->processExpression(expression);
	tp->displayParseTree();
	cout << "The result is: " << tp->computeAnswer() << endl; //Should display 3 as a double output

	expression = "(4^3)";
	tp->processExpression(expression);
	tp->displayParseTree();
	cout << "The result is: " << tp->computeAnswer() << endl; //Should display 64 as a double output

	expression = "((2-5)-5)";
	tp->processExpression(expression);
	tp->displayParseTree();
	cout << "The result is: " << tp->computeAnswer() << endl; //Should display -8 as a double output
	
	expression = "(5*(6/2))";
	tp->processExpression(expression);
	tp->displayParseTree();
	cout << "The result is: " << tp->computeAnswer() << endl; //Should display 15 as a double output
	
	expression = "((1 + 2) * (3 + 4))";
	tp->processExpression(expression);
	tp->displayParseTree();
	cout << "The result is: " << tp->computeAnswer() << endl; //Should display 21 as a double output

	expression = "(543+321)";
	tp->processExpression(expression);
	tp->displayParseTree();
	cout << "The result is: " << tp->computeAnswer() << endl; //Should display 864 as a double output

	expression = "(((((3+12)-7)*120)/(2+3))^3)";
	tp->processExpression(expression);
	tp->displayParseTree();
	cout << "The result is: " << tp->computeAnswer() << endl; //Should display close to 7077888 as a double output
	
	expression = "(((((9+(2*(110-(30/2))))*8)+1000)/2)+(((3^4)+1)/2))";
	tp->processExpression(expression);
	tp->displayParseTree();
	cout << "The result is: " << tp->computeAnswer() << endl; //Should display close to 1337 as a double/decimal output
	
	pressAnyKeyToContinue();
	return 0;
}
