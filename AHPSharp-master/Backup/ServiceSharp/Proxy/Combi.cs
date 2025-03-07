﻿//
// ServiceSharp Copyright (C) 2016 Fatih.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
using System;
namespace ServiceSharp {

	//[DataContract]
	public class Combi {

		//[DataMember]
		public string brand { get; set; }
		//[DataMember]
		public string model { get; set; }
		//[DataMember]
		public string type { get; set; }


		//[DataMember]
		public int price { get; set; }
		//[DataMember]
		public int power { get; set; }

		//[DataMember]
		public int area { get; set; }
		//[DataMember]
		public int warranty { get; set; }

		//[DataMember]
		public Dimension dimension { get; set; }

		//[DataMember]
		public string image { get; set; }

		//[DataMember]
		public int safety { get; set; }
	}
}
