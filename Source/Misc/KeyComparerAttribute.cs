﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordler {
	class KeyComparerAttribute : Attribute {
		public Type KeyComparer { get; set; }

		public KeyComparerAttribute(Type keyComparer) {
			KeyComparer = keyComparer;
		}
	}
}
