//Copyright 2017, Bradley Peterson, Weber State University, all rights reserved.

#include <cstdio>
#include <random>
#include <thread> //C++11 support!   Visual studio 2012+ users can use this if they want.
#include <mutex> 
#include <iostream>
#include <vector>
#include <memory>
#include <string>


//To prevent those using g++ from trying to use a library
//they don't have
#ifndef __GNUC__
#include <conio.h>
#else
#include <stdio.h>
#endif

using std::cout;
using std::endl;
using std::vector;
using std::unique_ptr;
using std::string;
using std::thread;
using std::mutex;

//*** Prototypes ***
void recQuickSort(vector<unsigned long>& arr, int first, int last);
void pressAnyKeyToContinue();
class BucketsCollection;

//***GLOBAL VARIABLES***
unique_ptr<unsigned long[]> list;
int listSize;
int numBuckets;
int numThreads;
unique_ptr<BucketsCollection> globalBuckets;

const unsigned long ULONGMAX = 4294967295;
mutex mymutex;

class BucketsCollection {
public:
  BucketsCollection(const unsigned int numBuckets);
  ~BucketsCollection() {}
  void addItem(unsigned long item);
  unsigned int getNumBuckets() const;
  unsigned int getNumItemsInABucket(const unsigned int bucket) const;
  vector<unsigned long>& getBucket(const unsigned int bucket);
  void copyOneBucketsIntoAnotherBuckets(BucketsCollection& smallBucket);
  void printAllBuckets() const;

private:
  vector< vector<unsigned long> > arr;
  unsigned int buckets;
  unsigned long range;

};

//*** Provide methods for the bucket class ***
BucketsCollection::BucketsCollection(const unsigned int numBuckets) {
  arr.resize(numBuckets);
  buckets = numBuckets;
  if (numBuckets > 1) {
    range = (ULONGMAX / buckets) + 1;
  }
  else {
    range = ULONGMAX;
  }
}


void BucketsCollection::addItem(unsigned long item) {
  //TODO:
	arr[item / range].push_back(item);
}

unsigned int BucketsCollection::getNumBuckets() const {
  return buckets;
}

unsigned int BucketsCollection::getNumItemsInABucket(const unsigned int bucket) const {
  return arr[bucket].size();
}

void BucketsCollection::printAllBuckets() const {
  //Displays the contents of all buckets to the screen.

  // just uncomment this code when you have arr properly declared as a data member
  printf("******\n");
  for (int i = 0; i < numBuckets; i++) {
    printf("bucket number %d\n", i);
    for (unsigned int j = 0; j < arr[i].size(); j++) {
      printf("%08x ", arr[i][j]);

    }
    printf("\n");
  }
  printf("\n");
}

vector<unsigned long>& BucketsCollection::getBucket(const unsigned int bucket) {
  return arr[bucket];
}


void BucketsCollection::copyOneBucketsIntoAnotherBuckets(BucketsCollection& smallBucket) {
  //Copies all items in all buckets from one BucketsCollection object into another BucketsCollection object.  
  //Not for the first part of the homework assignment, only the multithreaded part.


	mymutex.lock();

	for (int i = 0; i < smallBucket.getNumBuckets(); i++) {
		for (int j = 0; j < smallBucket.getNumItemsInABucket(i); j++) {
			globalBuckets->addItem(smallBucket.getBucket(i).at(j));
		}
	}
	
	
	mymutex.unlock();
}


//***Functions that help our bucket sort work.***
void printList() {
  for (int i = 0; i < listSize; i++) {
    //cout << list[i] << " ";
    printf("%08x ", list[i]);
  }
}

void createList() {
  list = std::make_unique<unsigned long[]>(listSize);

  std::random_device rd;
  std::mt19937 gen(rd());
  std::uniform_int_distribution<unsigned long> dis(0, ULONGMAX);

  for (int i = 0; i < listSize; i++) {
    list[i] = dis(gen);
  }
}
void placeIntoBuckets(int thread) {

	// Each thread needs own bucket collection object. 
	BucketsCollection threadBuckets = BucketsCollection(numBuckets);
	unsigned int startIndex = listSize / numThreads * thread; // 100/4 *0 = 0 100/4 *1 =25 ...
	unsigned int endIndex = listSize / numThreads * (thread + 1);
	
	// Puts data into small buckets and serpeates list array 
	for (int i = startIndex; i < endIndex; i++) {
		threadBuckets.addItem(list[i]);
		}

	//printf("I am thread %d and my starting point is %d and my end point is %d \n", thread, startIndex,endIndex);
	
	// start to export of buckets 
	globalBuckets->copyOneBucketsIntoAnotherBuckets(threadBuckets);

  //TODO: Put the values into the appropriate buckets.
	// Single Thread
	//for (int i = 0; i < listSize; i++) {
	//globalBuckets->addItem(list[i]);
	//}

}


void sortEachBucket(int thread) {

  //TODO: Sort each individual bucket
	//for (int i = 0; i < numBuckets; i++) {
		recQuickSort(globalBuckets->getBucket(thread), 0, globalBuckets->getNumItemsInABucket(thread));
	//}
}


void combineBuckets(int thread) {
  //TODO: Copy each bucket back out to the original list[] array

  //Loop for the amount of buckets
  //Get the individual bucket out of the globalBuckets
  //Copy all items from that individual bucket into the list array.

	// start of multi thread
	int threadBucketStart = 0;
	for (int i = 0; i < thread; i++) {
		threadBucketStart += globalBuckets->getNumItemsInABucket(i);
	}
// 	printf("I am thread %d and my starting point is %d", thread, threadBucketStart);

	for (int j = 0; j < globalBuckets->getNumItemsInABucket(thread); j++) {
		list[threadBucketStart] = globalBuckets->getBucket(thread).at(j);
		threadBucketStart++;
	}
	// end of multi thread

	//int count = 0;
	
	//for (int i = 0; i < numBuckets; i++) {
	//	for (int j = 0; j < globalBuckets->getNumItemsInABucket(i); j++) {
	//		list[count] = globalBuckets->getBucket(i).at(j);
	//			count++;
	//	}
	//	}


}


void bucketSort(bool displayOutput) {

  // Need to create thread counter object here.
	std::unique_ptr< thread[] > threads = std::make_unique< thread[] > (numThreads);
  // seperate threads and joins for every bucket method
  //For the upcoming homeowork assignment, I think it will help you the most to split your work into these three functions.  
  //placeIntoBuckets();
  // Create Thread
 for (int i = 0; i < numThreads; i++) {
	  threads[i] = thread(placeIntoBuckets, i);
	}
   //Wait to join
  for (int i = 0; i < numThreads; i++) {
	  threads[i].join();
  }
  if (displayOutput) {
    printf("Displaying each bucket's contents before sorting: \n");
    globalBuckets->printAllBuckets();
  }
  
  // create thread
  for (int i = 0; i < numThreads; i++) {
	  threads[i] = thread(sortEachBucket, i);
  }
  // Wait to join
  for (int i = 0; i < numThreads; i++) {
	  threads[i].join();
  }
  
  // create thread
  for (int i = 0; i < numThreads; i++) {
	  threads[i] = thread(combineBuckets, i);
  }
  // Wait to join
  for (int i = 0; i < numThreads; i++) {
	  threads[i].join();
  }

  if (displayOutput) {
    printf("Displaying each bucket's contents after sorting: \n");
    globalBuckets->printAllBuckets();
    pressAnyKeyToContinue();
    printf("Displaying what is hopefully a sorted array: \n");
    printList(); //See if it's all sorted.
  }
}


int partition(vector<unsigned long>& arr, int first, int last) {
  unsigned long pivot;
  int index, smallIndex;

  unsigned long temp;

  //Take the middle value as the pivot.
  //swap(first, (first + last) / 2);
  pivot = arr[first];
  smallIndex = first;
  for (index = first + 1; index < last; index++) {
    if (arr[index] < pivot) {
      smallIndex++;
      //swap the two
      temp = arr[smallIndex];
      arr[smallIndex] = arr[index];
      arr[index] = temp;
    }
  }

  //Move pivot into the sorted location
  temp = arr[first];
  arr[first] = arr[smallIndex];
  arr[smallIndex] = temp;

  //Tell where the pivot is
  return smallIndex;

}


void recQuickSort(vector<unsigned long>& arr, int first, int last) {
  //first is the first index
  //last is the one past the last index (or the size of the array
  //if first is 0)

  if (first < last) {
    //Get this sublist into two other sublists, one smaller and one bigger
    int pivotLocation = partition(arr, first, last);
    recQuickSort(arr, first, pivotLocation);
    recQuickSort(arr, pivotLocation + 1, last);
  }
}


void verifySort(unique_ptr<unsigned long[]>& arr, unsigned int arraySize, std::chrono::duration<double, std::milli>& diff, const string& sortTest) {
  double val = diff.count();
  for (unsigned int i = 1; i < arraySize; i++) {
    if (arr[i] < arr[i - 1]) {
      printf("\n");
      printf("------------------------------------------------------\n");
      printf("SORT TEST %s\n", sortTest.c_str());

      if (val != 0.0) {
        printf("Finished bucket sort in %1.16lf milliseconds\n", diff.count());
      }
      printf("ERROR - This list was not sorted correctly.  At index %d is value %08X.  At index %d is value %08X\n", sortTest.c_str(), i - 1, arr[i - 1], i, arr[i]);
      printf("------------------------------------------------------\n");


      return;
    }
  }
  printf("\n");
  printf("------------------------------------------------------\n");
  printf("SORT TEST %s\n", sortTest.c_str());
  if (val != 0.0) {
    printf("Finished bucket sort in %1.16lf milliseconds\n", diff.count());
  }
  printf("PASSED SORT TEST - The list was sorted correctly\n", sortTest.c_str());
  printf("------------------------------------------------------\n");
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

  std::chrono::duration<double, std::milli> diff{ 0 };

  //Set the listSize, numBuckets, and numThreads global variables.  
  listSize = 100;

  numBuckets = 2;
  numThreads = 2;
  createList();
  globalBuckets = std::make_unique<BucketsCollection>(numBuckets);
  printf("\nStarting bucket sort for listSize = %d, numBuckets = %d, numThreads = %d\n", listSize, numBuckets, numThreads);
  // printf("Displaying the unsorted list array:\n");
  // printList(); //useful for debugging small amounts of numbers.  
  pressAnyKeyToContinue();
  bucketSort(true);
  verifySort(list, listSize, diff, "2 buckets");
  pressAnyKeyToContinue();


  numBuckets = 4;
  numThreads = 4;
  createList();
  printf("\nStarting bucket sort for listSize = %d, numBuckets = %d, numThreads = %d\n", listSize, numBuckets, numThreads);
  globalBuckets = std::make_unique<BucketsCollection>(numBuckets);
  pressAnyKeyToContinue();
  bucketSort(true);
  verifySort(list, listSize, diff, "4 buckets");
  pressAnyKeyToContinue();

  printf("\nFor timing purposes, please make sure any debugging printf statements you added are commented out\n");
  pressAnyKeyToContinue();

  listSize = 4000000;
  numBuckets = 1;
  numThreads = 1;
  createList();
  globalBuckets = std::make_unique<BucketsCollection>(numBuckets);
  //printf("Starting bucket sort for listSize = %d, numBuckets = %d, numThreads = %d, this is effectively a quick sort\n", listSize, numBuckets, numThreads);
  auto start = std::chrono::high_resolution_clock::now();
  bucketSort(false);
  auto end = std::chrono::high_resolution_clock::now();
  diff = end - start;
  verifySort(list, listSize, diff, "4000000 items in 1 bucket - BASELINE");


  listSize = 4000000;
  numBuckets = 2;
  numThreads = 2;
  createList();
  globalBuckets = std::make_unique<BucketsCollection>(numBuckets);
  // printf("Starting bucket sort for listSize = %d, numBuckets = %d, numThreads = %d\n", listSize, numBuckets, numThreads);
  start = std::chrono::high_resolution_clock::now();
  bucketSort(false);
  end = std::chrono::high_resolution_clock::now();
  diff = end - start;
  verifySort(list, listSize, diff, "4000000 items in 2 buckets");

  numBuckets = 4;
  numThreads = 4;
  createList();
  globalBuckets = std::make_unique<BucketsCollection>(numBuckets);
  //printf("Starting bucket sort for listSize = %d, numBuckets = %d, numThreads = %d\n", listSize, numBuckets, numThreads);
  start = std::chrono::high_resolution_clock::now();
  bucketSort(false);
  end = std::chrono::high_resolution_clock::now();
  diff = end - start;
  verifySort(list, listSize, diff, "4000000 items in 4 buckets");

  numBuckets = 8;
  numThreads = 8;
  createList();
  globalBuckets = std::make_unique<BucketsCollection>(numBuckets);
  //printf("Starting bucket sort for listSize = %d, numBuckets = %d, numThreads = %d\n", listSize, numBuckets, numThreads);
  start = std::chrono::high_resolution_clock::now();
  bucketSort(false);
  end = std::chrono::high_resolution_clock::now();
  diff = end - start;
  verifySort(list, listSize, diff, "4000000 items in 8 buckets");

  numBuckets = 16;
  numThreads = 16;
  createList();
  globalBuckets = std::make_unique<BucketsCollection>(numBuckets);
  //printf("Starting bucket sort for listSize = %d, numBuckets = %d, numThreads = %d\n", listSize, numBuckets, numThreads);
  start = std::chrono::high_resolution_clock::now();
  bucketSort(false);
  end = std::chrono::high_resolution_clock::now();
  diff = end - start;
  verifySort(list, listSize, diff, "4000000 items in 16 buckets");

  pressAnyKeyToContinue();
  return 0;
}
