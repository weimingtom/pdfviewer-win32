#pragma once
#include "PDFTextWord.h"
using namespace System;
using namespace System::Collections;

namespace PDFLibNet
{
	generic <class T>
	where T:PDFTextWord
	public ref struct PDFTextWordList 
		: public Generic::IEnumerable<T>
	{   
		PDFTextWordInterop *data;
	    PDFTextWordInterop *firstWord;
		Generic::List<PDFTextWord^>^ _wordsList;

		PDFTextWordList(PDFTextWordInterop *word )
		{
			firstWord = word;
			data = word;
			PDFTextWord^ wordObj = gcnew PDFTextWord(word);
			
			_wordsList = gcnew Generic::List<PDFTextWord^>();
			_wordsList->Add(wordObj);
		}
	public:    		
		virtual Generic::IEnumerator<T>^ GetEnumerator()
		{
			return gcnew TagEnumerator(this);
		}
	    
		virtual System::Collections::IEnumerator^ GetEnumerator2() new sealed = System::Collections::IEnumerable::GetEnumerator
		{
			return gcnew TagEnumerator(this);
		}
	private:
		ref struct TagEnumerator : public System::Collections::Generic::IEnumerator<T>
		{
			int currentIndex;
			PDFTextWordList^ myArr;
		public:
			TagEnumerator( PDFTextWordList^ arr )
			{
				myArr = arr;
				currentIndex = -1;
			}

			virtual bool MoveNext()
			{
				if(myArr->data != nullptr)
				{
					PDFTextWordInterop *nextWord = myArr->data->getNext();
					if(nextWord == 0)
						return false;
					myArr->data = nextWord;
					PDFTextWord^ word = gcnew PDFTextWord(nextWord);
					myArr->_wordsList->Add(word);
					currentIndex++;
					return true;
				}	
				return false;
			}
	    
			virtual property T Current
			{
				T get()
				{

					return  (T)myArr->_wordsList[currentIndex];
				}
			};
			// This is required as IEnumerator<T> also implements IEnumerator
			virtual property Object^ Current2
			{
				virtual Object^ get() new sealed = System::Collections::IEnumerator::Current::get
				{
					return myArr->_wordsList[currentIndex];
				}
			};
	        
			virtual void Reset() 
			{ 
				currentIndex = 0;
				myArr->data = myArr->firstWord;

			}
			~TagEnumerator() {}
	            
		};
	};
}