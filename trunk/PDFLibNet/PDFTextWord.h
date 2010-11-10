#pragma once
#include "AFPDFDocInterop.h"
#include "PDFPageInterop.h"
#include "PDFTextBlockInterop.h"

using namespace System;
using namespace System::Drawing;
using namespace System::Runtime::InteropServices;

namespace PDFLibNet
{
	ref class PDFWrapper;

	public ref class PDFTextWord
	{
	private:
		PDFTextWordInterop *_word;
	internal:
		PDFTextWord(PDFTextWordInterop *word);
	};

}