#include "PDFPageInterop.h"
#include "AFPDFDoc.h"
#include "AFPDFDocInterop.h"
#include "TextOutputDev.h"
#include "CRect.h"

static wchar_t		EmptyChar[1]						={'\0'};

//Try to decode UTF-8
wchar_t* UTF8translate(char artist[])
{
	int nNeeded = MultiByteToWideChar( CP_UTF8, NULL, artist, -1, 0, 0 );
	if( !nNeeded )
	{
		return NULL;
	}
 
	wchar_t* pWideChar = new wchar_t[nNeeded + 1];
	if( !MultiByteToWideChar( CP_UTF8, NULL, artist, -1, pWideChar, nNeeded ))
	{
		delete[] pWideChar;
		return NULL;
	}
	
	return pWideChar;
}

	PDFTextBlockInterop::PDFTextBlockInterop(void *pdfPage, void *textBlock, int blockNumber, int pageNumber)
		: _pdfPage(pdfPage)
		, _page(pageNumber)
		, _textBlock(textBlock)
		, _currentBlock(blockNumber)
		, _lines(NULL)
		, next(NULL)
	{ 
	}

	PDFTextLineInterop *PDFTextBlockInterop::getLines()
	{
		if(_lines == NULL)
		{
			TextBlock *block = (TextBlock *)this->_textBlock;
			TextLine *topLine = block->getLines();
			_lines = new PDFTextLineInterop(this, (void *)topLine, 0);
		}
		return _lines;
	}

	PDFTextBlockInterop *PDFTextBlockInterop::getNext()
	{
		if(next == NULL)
		{
			 TextBlock *block = (TextBlock *)this->_textBlock;
			 TextBlock *nextBlock = block->getNext();
			 if(nextBlock == NULL)
				 return NULL;
			 next = new PDFTextBlockInterop(_pdfPage,(void *)nextBlock, this->_currentBlock + 1,this->_page);
		}
		return next;
	}

	int PDFTextBlockInterop::getLinesCount()
	{
		TextBlock *block = (TextBlock *)this->_textBlock;
		return block->getLineCount();
	}

	PDFTextLineInterop::PDFTextLineInterop(PDFTextBlockInterop *block, void *textLine, int currentTextLine)
		: _textBlock(block)
		, _textLine(textLine)
		, _currentLine(currentTextLine)
		, next(NULL)
		, _words(NULL)
		, _wordCount(-1)
	{
	}

	PDFTextWordInterop *PDFTextLineInterop::getWords()
	{
		if(_words == NULL)
		{
			TextLine *line = (TextLine *)_textLine;
			TextWord *words = line->getWords();
			_words = new PDFTextWordInterop(_textBlock, this, words, 0);
		}
		return _words;
	}

	int PDFTextLineInterop::getWordCount()
	{
		if(_wordCount == -1)
		{
			TextLine *line = (TextLine *)_textLine;
			TextWord *words = line->getWords();
			TextWord *word = NULL;
			_wordCount = 0;
			while(words)
			{
				word = words;
				words = words->getNext();
				_wordCount++;
			}
		}
		return _wordCount;
	}

	PDFTextLineInterop *PDFTextLineInterop::getNext()
	{
		if(next == NULL)
		{
			TextLine *line = (TextLine *)_textLine;
			TextLine *nextLine = line->getNext();
			if(nextLine == NULL)
				return NULL;
			next = new PDFTextLineInterop(_textBlock, nextLine, _currentLine +1);
		}
		return next;
	}

	PDFTextWordInterop::PDFTextWordInterop(PDFTextBlockInterop *block, PDFTextLineInterop *textLine, void *textWord, int currentWord)
		: _textBlock(block)
		, _textLine(textLine)
		, _textWord(textWord)
		, _currentWord(currentWord)
		, next(NULL)
	{
	}

	