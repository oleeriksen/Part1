﻿using System;
namespace Modul5
{
	public class Person
	{
		// State
		public string name = String.Empty;
		public string address = String.Empty;
		public DateTime birthday;
		public int height;
		public double weight;

		// Constructors
		public Person() { }

		public Person(string name, string address, int height, double weight) {
			this.name = name;
			this.address = address;
			this.height = height;
			this.weight = weight;
		}

		// Methods and functions
		public bool IsTeenager() { return true;  }

		public double BMI() { return 0; }

		public int DistanceFrom(double lat, double lgd) { return 0; }
	}
}

