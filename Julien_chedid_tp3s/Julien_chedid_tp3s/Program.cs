﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;



namespace julien_chedid
{
    public class MovieCollection
    {
        public List<WaltDisneyMovies> Movies { get; set; } = new List<WaltDisneyMovies>
        {
            new WaltDisneyMovies("Snow White and the Seven Dwarfs", "David Hand", 83.0, 1490000.0, 418000000.0, new DateTime(1937, 12, 21)),
            new WaltDisneyMovies("Pinocchio", "Ben Sharpsteen", 88.0, 2600000.0, 164000000.0, new DateTime(1940, 02, 07)),
            new WaltDisneyMovies("Fantasia", "Samuel Armstrong", 126.0, 2280000.0, 83300000.0, new DateTime(1940, 11, 13)),
            new WaltDisneyMovies("The Reluctant Dragon", "Alfred Werker", 74.0, 600000.0, 960000.0, new DateTime(1941, 06, 27)),
            new WaltDisneyMovies("Dumbo", "Ben Sharpsteen", 64.0, 950000.0, 1300000.0, new DateTime(1941, 10, 23)),
            new WaltDisneyMovies("Bambi", "Supervising director", 70.0, 858000.0, 267400000.0, new DateTime(1942, 08, 09)),
            new WaltDisneyMovies("Saludos Amigos", "Norman Ferguson", 42.0, null, 1135000.0, new DateTime(1942, 08, 24)),
            new WaltDisneyMovies("Victory Through Air Power", "James Algar", 70.0, 788000.0, 799000.0, new DateTime(1943, 07, 17)),
            new WaltDisneyMovies("The Three Caballeros", "Norman Ferguson", 71.0, null, 3355000.0, new DateTime(1944, 12, 21)),
            new WaltDisneyMovies("Make Mine Music", "Jack Kinney", 75.0, 1350000.0, 3275000.0, new DateTime(1946, 04, 20)),
            new WaltDisneyMovies("Song of the South", "Harve Foster", 94.0, 2125000.0, 65000000.0, new DateTime(1946, 11, 12)),
            new WaltDisneyMovies("Fun and Fancy Free", "William Morgan", 73.0, null, 3165000.0, new DateTime(1947, 09, 27)),
            new WaltDisneyMovies("Melody Time", "Jack Kinney", 75.0, 1500000.0, 2560000.0, new DateTime(1948, 05, 27)),
            new WaltDisneyMovies("So Dear to My Heart Harold", "D. Schuster", 82.0, 1500000.0, 3700000.0, new DateTime(1948, 11, 29)),
            new WaltDisneyMovies("The Adventures of Ichabod and Mr. Toad", "Jack Kinney", 68.0, null, 1625000.0, new DateTime(1949, 10, 05)),
            new WaltDisneyMovies("Cinderella", "Clyde Geronimi", 74.0, 2200000.0, 263600000.0, new DateTime(1950, 02, 15)),
            new WaltDisneyMovies("Treasure Island", "Byron Haskin", 96.0, 1800000.0, 4100000.0, new DateTime(1950, 06, 22)),
            new WaltDisneyMovies("Alice in Wonderland", "Clyde Geronimi", 75.0, 3000000.0, 2400000.0, new DateTime(1951, 07, 26)),
            new WaltDisneyMovies("The Story of Robin Hood", "Ken Annakin", 84.0, null, 2100000.0, new DateTime(1952, 03, 13)),
            new WaltDisneyMovies("Peter Pan", "Clyde Geronimi", 77.0, 4000000.0, 87400000.0, new DateTime(1953, 02, 05)),
            new WaltDisneyMovies("The Sword and the Rose", "Ken Annakin", 92.0, 2000000.0, 1000000.0, new DateTime(1953, 07, 23)),
            new WaltDisneyMovies("The Living Desert", "James Algar", 69.0, 300000.0, 2600000.0, new DateTime(1953, 11, 10)),
            new WaltDisneyMovies("Rob Roy: The Highland Rogue", "Harold French", 81.0, 1800000.0, null, new DateTime(1953, 10, 26)),
            new WaltDisneyMovies("The Vanishing Prairie", "James Algar", 60.0, null, 1750000.0, new DateTime(1954, 08, 17)),
            new WaltDisneyMovies("20,000 Leagues Under the Sea", "Richard Fleischer", 127.0, 5000000.0, 28200000.0, new DateTime(1954, 12, 23)),
            new WaltDisneyMovies("Davy Crockett: King of the Wild Frontier", "Norman Foster", 92.0, null, 2150000.0, new DateTime(1955, 05, 25)),
            new WaltDisneyMovies("Lady and the Tramp", "Hamilton Luske", 76.0, 4000000.0, 187000000.0, new DateTime(1955, 06, 22)),
            new WaltDisneyMovies("The African Lion", "James Algar", 75.0, null, 2100000.0, new DateTime(1955, 09, 14)),
            new WaltDisneyMovies("The Littlest Outlaw", "Roberto Gavaldan", 73.0, null, 1600000.0, new DateTime(1955, 12, 22)),
            new WaltDisneyMovies("The Great Locomotive Chase Francis", "D. Lyon", 85.0, null, 1700000.0, new DateTime(1956, 06, 08)),
            new WaltDisneyMovies("Davy Crockett and the River Pirates", "Norman Foster", 81.0, null, 0.0, new DateTime(1956, 07, 18)),
            new WaltDisneyMovies("Secrets of Life", "James Algar", 70.0, null, 0.0, new DateTime(1956, 09, 04)),
            new WaltDisneyMovies("Westward Ho the Wagons!", "William Beaudine", 90.0, null, 2750000.0, new DateTime(1956, 12, 20)),
            new WaltDisneyMovies("Johnny Tremain", "Robert Stevenson", 80.0, 700000.0, null, new DateTime(1957, 06, 19)),
            new WaltDisneyMovies("Perri N.", "Paul Kenworthy", 75.0, null, 1750000.0, new DateTime(1957, 08, 28)),
            new WaltDisneyMovies("Old Yeller", "Robert Stevenson", 83.0, null, 6250000.0, new DateTime(1957, 12, 25)),
            new WaltDisneyMovies("The Light in the Forest", "Herschel Daugherty", 83.0, null, 0.0, new DateTime(1958, 07, 08)),
            new WaltDisneyMovies("White Wilderness", "James Algar", 72.0, null, 1800000.0, new DateTime(1958, 08, 12)),
            new WaltDisneyMovies("Tonka Lewis", "R. Foster", 97.0, null, 2500000.0, new DateTime(1958, 12, 25)),
            new WaltDisneyMovies("Sleeping Beauty", "Les Clark", 75.0, 6000000.0, 51600000.0, new DateTime(1959, 01, 29)),
            new WaltDisneyMovies("The Shaggy Dog", "Charles Barton", 104.0, 1000000.0, 12300000.0, new DateTime(1959, 03, 19)),
            new WaltDisneyMovies("Darby O'Gill and the Little People", "Robert Stevenson", 93.0, null, 0.0, new DateTime(1959, 06, 24)),
            new WaltDisneyMovies("Third Man on the Mountain", "Ken Annakin", 105.0, 2000000.0, 1700000.0, new DateTime(1959, 11, 10)),
            new WaltDisneyMovies("Toby Tyler or 10 Weeks with a Circus", "Charles Barton", 95.0, null, 3100000.0, new DateTime(1960, 01, 21)),
            new WaltDisneyMovies("Kidnapped", "Robert Stevenson", 97.0, null, 0.0, new DateTime(1960, 02, 24)),
            new WaltDisneyMovies("Pollyanna", "David Swift", 134.0, 2500000.0, 3750000.0, new DateTime(1960, 03, 19)),
            new WaltDisneyMovies("Jungle Cat", "James Algar", 69.0, null, 2300000.0, new DateTime(1960, 05, 20)),
            new WaltDisneyMovies("Ten Who Dared", "William Beaudine", 92.0, null, 0.0, new DateTime(1960, 11, 01)),
            new WaltDisneyMovies("Swiss Family Robinson", "Ken Annakin", 131.0, 4000000.0, 40000000.0, new DateTime(1960, 12, 21)),
            new WaltDisneyMovies("One Hundred and One Dalmatians", "Clyde Geronimi", 79.0, 3600000.0, 303000000.0, new DateTime(1961, 01, 25)),
            new WaltDisneyMovies("The Absent-Minded Professor", "Robert Stevenson", 97.0, null, 25400000.0, new DateTime(1961, 03, 16)),
            new WaltDisneyMovies("The Parent Trap", "David Swift", 128.0, null, 25100000.0, new DateTime(1961, 06, 21)),
            new WaltDisneyMovies("Nikki: Wild Dog of the North", "Jack Couffer", 74.0, null, 0.0, new DateTime(1961, 07, 12)),
            new WaltDisneyMovies("Greyfriars Bobby", "Don Chaffey", 91.0, null, 0.0, new DateTime(1961, 07, 17)),
            new WaltDisneyMovies("Babes in Toyland", "Jack Donohue", 105.0, 3000000.0, 4600000.0, new DateTime(1961, 12, 14)),
            new WaltDisneyMovies("Moon Pilot", "James Neilson", 98.0, null, 3500000.0, new DateTime(1962, 04, 05)),
            new WaltDisneyMovies("Bon Voyage!", "James Neilson", 130.0, 3000000.0, 5000000.0, new DateTime(1962, 05, 17)),
            new WaltDisneyMovies("Big Red", "Norman Tokar", 89.0, null, 0.0, new DateTime(1962, 06, 06)),
            new WaltDisneyMovies("Almost Angels", "Steve Previn", 93.0, null, 0.0, new DateTime(1962, 09, 26)),
            new WaltDisneyMovies("The Legend of Lobo", "James Algar", 67.0, null, 0.0, new DateTime(1962, 11, 07)),
            new WaltDisneyMovies("In Search of the Castaways", "Robert Stevenson", 98.0, null, 21745500.0, new DateTime(1962, 11, 14)),
            new WaltDisneyMovies("Son of Flubber", "Robert Stevenson", 100.0, null, 22100000.0, new DateTime(1963, 01, 16)),
            new WaltDisneyMovies("Miracle of the White Stallions", "Arthur Hiller", 118.0, null, 2550000.0, new DateTime(1963, 03, 29)),
            new WaltDisneyMovies("Savage Sam", "Norman Tokar", 103.0, null, 3000000.0, new DateTime(1963, 06, 01)),
            new WaltDisneyMovies("Summer Magic", "James Neilson", 110.0, null, 4350000.0, new DateTime(1963, 07, 07)),
            new WaltDisneyMovies("The Incredible Journey", "Fletcher Markle", 80.0, null, 4200000.0, new DateTime(1963, 11, 20)),
            new WaltDisneyMovies("The Sword in the Stone", "Wolfgang Reitherman", 79.0, 3000000.0, 22200000.0, new DateTime(1963, 12, 25)),
            new WaltDisneyMovies("A Tiger Walks", "Norman Tokar", 91.0, null, 1600000.0, new DateTime(1964, 03, 12)),
            new WaltDisneyMovies("The Misadventures of Merlin Jones", "Robert Stevenson", 91.0, null, 4000000.0, new DateTime(1964, 02, 11)),
            new WaltDisneyMovies("The Three Lives of Thomasina", "Don Chaffey", 97.0, null, 2250000.0, new DateTime(1963, 12, 11)),
            new WaltDisneyMovies("The Moon-Spinners", "James Neilson", 118.0, null, 3500000.0, new DateTime(1964, 07, 02)),
            new WaltDisneyMovies("Mary Poppins", "Robert Stevenson", 139.0, 4400000.0, 103100000.0, new DateTime(1964, 08, 27)),
            new WaltDisneyMovies("Emil and the Detectives", "Peter Tewksbury", 92.0, null, 1275000.0, new DateTime(1964, 12, 18)),
            new WaltDisneyMovies("Those Calloways", "Norman Tokar", 131.0, null, 3500000.0, new DateTime(1965, 01, 28)),
            new WaltDisneyMovies("The Monkey's Uncle", "Robert Stevenson", 87.0, null, 4000000.0, new DateTime(1965, 08, 18)),
            new WaltDisneyMovies("That Darn Cat!", "Robert Stevenson", 116.0, null, 28068222.0, new DateTime(1965, 12, 02)),
            new WaltDisneyMovies("The Ugly Dachshund", "Norman Tokar", 93.0, null, 6200000.0, new DateTime(1966, 02, 04)),
            new WaltDisneyMovies("Lt. Robin Crusoe, U.S.N.", "Byron Paul", 110.0, null, 22565634.0, new DateTime(1966, 06, 25)),
            new WaltDisneyMovies("The Fighting Prince of Donegal Michael", "O'Herlihy", 110.0, null, 0.0, new DateTime(1966, 10, 01)),
            new WaltDisneyMovies("Follow Me, Boys!", "Norman Tokar", 131.0, null, 16207116.0, new DateTime(1966, 12, 01)),
            new WaltDisneyMovies("Monkeys, Go Home! Andrew", "V. McLaglen", 101.0, null, 3000000.0, new DateTime(1967, 02, 08)),
            new WaltDisneyMovies("The Adventures of Bullwhip Griffin", "James Neilson", 108.0, null, 1900000.0, new DateTime(1967, 06, 15)),
            new WaltDisneyMovies("The Gnome-Mobile", "Robert Stevenson", 84.0, null, 4000000.0, new DateTime(1967, 07, 12)),
            new WaltDisneyMovies("The Jungle Book", "Wolfgang Reitherman", 78.0, 4000000.0, 378000000.0, new DateTime(1967, 10, 18)),
            new WaltDisneyMovies("Charlie, the Lonesome Cougar", "Winston Hibler", 75.0, null, 0.0, new DateTime(1967, 10, 19)),
            new WaltDisneyMovies("The Happiest Millionaire", "Norman Tokar", 164.0, 5000000.0, 5000000.0, new DateTime(1967, 06, 23)),
            new WaltDisneyMovies("Blackbeard's Ghost", "Robert Stevenson", 106.0, null, 21540050.0, new DateTime(1968, 02, 08)),
            new WaltDisneyMovies("The One and Only, Genuine, Original Family Band Michael", "O'Herlihy", 110.0, null, 2250000.0, new DateTime(1968, 03, 21)),
            new WaltDisneyMovies("Never a Dull Moment", "Jerry Paris", 99.0, null, 4150000.0, new DateTime(1968, 06, 26)),
            new WaltDisneyMovies("The Horse in the Gray Flannel Suit", "Norman Tokar", 113.0, null, 3300000.0, new DateTime(1968, 12, 03)),
            new WaltDisneyMovies("The Love Bug", "Robert Stevenson", 108.0, 5000000.0, 51264000.0, new DateTime(1968, 12, 24)),
            new WaltDisneyMovies("Smith! Michael", "O'Herlihy", 112.0, null, 1300000.0, new DateTime(1969, 05, 09)),
            new WaltDisneyMovies("Rascal", "Norman Tokar", 93.0, null, 0.0, new DateTime(1969, 09, 04)),
            new WaltDisneyMovies("The Computer Wore Tennis Shoes", "Robert Butler", 91.0, null, 5500000.0, new DateTime(1969, 11, 28)),
            new WaltDisneyMovies("King of the Grizzlies", "Ron Kelly", 93.0, null, 0.0, new DateTime(1970, 02, 11)),
            new WaltDisneyMovies("The Boatniks", "Norman Tokar", 100.0, null, 18607492.0, new DateTime(1970, 07, 01)),
            new WaltDisneyMovies("The Wild Country", "Robert Totten", 100.0, null, 4000000.0, new DateTime(1970, 12, 15)),
            new WaltDisneyMovies("The Aristocats", "Wolfgang Reitherman", 79.0, 4000000.0, 191000000.0, new DateTime(1970, 12, 11)),
            new WaltDisneyMovies("The Barefoot Executive", "Robert Butler", 96.0, null, 0.0, new DateTime(1971, 03, 17)),
            new WaltDisneyMovies("Scandalous John", "Robert Butler", 113.0, null, 0.0, new DateTime(1971, 06, 22)),
            new WaltDisneyMovies("The Million Dollar Duck", "Vincent McEveety", 89.0, null, 5100000.0, new DateTime(1971, 06, 30)),
            new WaltDisneyMovies("Bedknobs and Broomsticks", "Robert Stevenson", 118.0, 6300000.0, 17900000.0, new DateTime(1971, 10, 07)),
            new WaltDisneyMovies("The Biscuit Eater", "Vincent McEveety", 92.0, null, 0.0, new DateTime(1972, 03, 22)),
            new WaltDisneyMovies("Now You See Him, Now You Don't", "Robert Butler", 88.0, null, 4610000.0, new DateTime(1972, 07, 12)),
            new WaltDisneyMovies("Napoleon and Samantha", "Bernard McEveety", 92.0, null, 0.0, new DateTime(1972, 07, 05)),
            new WaltDisneyMovies("Run, Cougar, Run", "Jerome Courtland", 87.0, null, 0.0, new DateTime(1972, 10, 18)),
            new WaltDisneyMovies("Snowball Express", "Norman Tokar", 93.0, null, 6100000.0, new DateTime(1972, 12, 22)),
            new WaltDisneyMovies("The World's Greatest Athlete", "Robert Scheerer", 93.0, null, 22583370.0, new DateTime(1973, 02, 01)),
            new WaltDisneyMovies("Charley and the Angel", "Vincent McEveety", 93.0, null, 0.0, new DateTime(1973, 03, 23)),
            new WaltDisneyMovies("One Little Indian", "Bernard McEveety", 90.0, null, 2000000.0, new DateTime(1973, 06, 20)),
            new WaltDisneyMovies("Robin Hood", "Wolfgang Reitherman", 83.0, 5000000.0, 32000000.0, new DateTime(1973, 11, 08)),
            new WaltDisneyMovies("Superdad", "Vincent McEveety", 96.0, null, 7000000.0, new DateTime(1973, 12, 14)),
            new WaltDisneyMovies("Herbie Rides Again", "Robert Stevenson", 88.0, null, 38229000.0, new DateTime(1974, 06, 06)),
            new WaltDisneyMovies("The Bears and I", "Bernard McEveety", 89.0, null, 4000000.0, new DateTime(1974, 07, 31)),
            new WaltDisneyMovies("The Castaway Cowboy", "Vincent McEveety", 91.0, null, 0.0, new DateTime(1974, 08, 01)),
            new WaltDisneyMovies("The Island at the Top of the World", "Robert Stevenson", 93.0, 8000000.0, 10000000.0, new DateTime(1974, 12, 20)),
            new WaltDisneyMovies("The Strongest Man in the World", "Vincent McEveety", 92.0, null, 6600000.0, new DateTime(1975, 02, 06)),
            new WaltDisneyMovies("Escape to Witch Mountain", "John Hough", 97.0, null, 20000000.0, new DateTime(1975, 03, 21)),
            new WaltDisneyMovies("The Apple Dumpling Gang", "Norman Tokar", 100.0, null, 36853000.0, new DateTime(1975, 07, 01)),
            new WaltDisneyMovies("One of Our Dinosaurs is Missing", "Robert Stevenson", 100.0, null, 5500000.0, new DateTime(1975, 07, 09)),
            new WaltDisneyMovies("The Best of Walt Disney's True-Life Adventures", "James Algar", 89.0, null, 0.0, new DateTime(1975, 10, 08)),
            new WaltDisneyMovies("Ride a Wild Pony", "Don Chaffey", 91.0, 1000000.0, null, new DateTime(1975, 12, 25)),
            new WaltDisneyMovies("No Deposit, No Return", "Norman Tokar", 112.0, null, 0.0, new DateTime(1976, 02, 11)),
            new WaltDisneyMovies("Treasure of Matecumbe", "Vincent McEveety", 115.0, null, 0.0, new DateTime(1976, 07, 01)),
            new WaltDisneyMovies("Gus", "Vincent McEveety", 95.0, null, 21873000.0, new DateTime(1976, 07, 07)),
            new WaltDisneyMovies("The Shaggy D.A.", "Robert Stevenson", 91.0, null, 10500000.0, new DateTime(1976, 12, 16)),
            new WaltDisneyMovies("Freaky Friday: The Movie", "Gary Nelson", 95.0, 5000000.0, 36000000.0, new DateTime(1976, 12, 17)),
            new WaltDisneyMovies("Escape from the Dark", "Charles Jarrott", 104.0, null, 0.0, new DateTime(1976, 05, 26)),
            new WaltDisneyMovies("The Many Adventures of", "John Lounsbery", 74.0, null, 0.0, new DateTime(1977, 03, 11)),
            new WaltDisneyMovies("A Tale of Two Critters", "Jack Speirs", 48.0, null, 0.0, new DateTime(1977, 06, 20)),
            new WaltDisneyMovies("The Rescuers", "Wolfgang Reitherman", 77.0, 7500000.0, 169000000.0, new DateTime(1977, 06, 22)),
            new WaltDisneyMovies("Herbie Goes to Monte Carlo", "Vincent McEveety", 104.0, null, 29000000.0, new DateTime(1977, 06, 24)),
            new WaltDisneyMovies("Pete's Dragon", "Don Chaffey", 128.0, 10000000.0, 36.0, new DateTime(1977, 11, 03)),
            new WaltDisneyMovies("Candleshoe", "Norman Tokar", 101.0, null, 0.0, new DateTime(1977, 12, 16)),
            new WaltDisneyMovies("Return from Witch Mountain", "John Hough", 94.0, null, 0.0, new DateTime(1978, 03, 10)),
            new WaltDisneyMovies("The Cat from Outer Space", "Norman Tokar", 104.0, 3500000.0, null, new DateTime(1978, 06, 30)),
            new WaltDisneyMovies("Hot Lead and Cold Feet", "Robert Butler", 90.0, null, 0.0, new DateTime(1978, 07, 05)),
            new WaltDisneyMovies("The North Avenue Irregulars", "Bruce Bilson", 100.0, null, 0.0, new DateTime(1979, 02, 09)),
            new WaltDisneyMovies("The Apple Dumpling Gang Rides Again", "Vincent McEveety", 88.0, null, 20931111.0, new DateTime(1979, 06, 27)),
            new WaltDisneyMovies("Unidentified Flying Oddball", "Russ Mayberry", 93.0, 5250000.0, null, new DateTime(1979, 07, 19)),
            new WaltDisneyMovies("The Black Hole", "Gary Nelson", 98.0, 20000000.0, 35800000.0, new DateTime(1979, 12, 18)),
            new WaltDisneyMovies("Midnight Madness", "Michael Nankin", 112.0, null, 2900000.0, new DateTime(1980, 02, 08)),
            new WaltDisneyMovies("The Watcher in the Woods", "John Hough", 84.0, 9000000.0, 5000000.0, new DateTime(1980, 04, 17)),
            new WaltDisneyMovies("Herbie Goes Bananas", "Vincent McEveety", 98.0, null, 18000000.0, new DateTime(1980, 06, 27)),
            new WaltDisneyMovies("The Last Flight of Noah's Ark", "Charles Jarrott", 97.0, 6000000.0, 11000000.0, new DateTime(1980, 07, 09)),
            new WaltDisneyMovies("Popeye", "Robert Altman", 114.0, 20000000.0, 60000000.0, new DateTime(1980, 12, 06)),
            new WaltDisneyMovies("The Devil and Max Devlin Steven", "Hilliard Stern", 96.0, null, 16000000.0, new DateTime(1981, 02, 11)),
            new WaltDisneyMovies("Amy", "Vincent McEveety", 100.0, null, 0.0, new DateTime(1981, 03, 20)),
            new WaltDisneyMovies("Dragonslayer", "Matthew Robbins", 109.0, 18000000.0, 14100000.0, new DateTime(1981, 06, 26)),
            new WaltDisneyMovies("The Fox and the Hound", "Art Stevens", 83.0, 12000000.0, 63500000.0, new DateTime(1981, 07, 10)),
            new WaltDisneyMovies("Condorman", "Charles Jarrott", 90.0, 14000000.0, null, new DateTime(1981, 08, 07)),
            new WaltDisneyMovies("Night Crossing", "Delbert Mann", 107.0, null, 8000000.0, new DateTime(1982, 02, 05)),
            new WaltDisneyMovies("Tron", "Steven Lisberger", 96.0, null, 0.0, new DateTime(1982, 07, 09)),
            new WaltDisneyMovies("Tex", "Tim Hunter", 103.0, 5000000.0, 7400000.0, new DateTime(1982, 07, 30)),
            new WaltDisneyMovies("Trenchcoat", "Michael Tuchner", 91.0, null, 4304286.0, new DateTime(1983, 03, 11)),
            new WaltDisneyMovies("Something Wicked This Way Comes", "Jack Clayton", 95.0, 20000000.0, 8400000.0, new DateTime(1983, 04, 29)),
            new WaltDisneyMovies("Never Cry Wolf", "Carroll Ballard", 105.0, 11000000.0, 27600000.0, new DateTime(1983, 10, 07)),
            new WaltDisneyMovies("Return to Oz", "Walter Murch", 113.0, 28000000.0, 11100000.0, new DateTime(1985, 06, 21)),
            new WaltDisneyMovies("The Black Cauldron", "Richard Rich", 80.0, 44000000.0, 21300000.0, new DateTime(1985, 07, 24)),
            new WaltDisneyMovies("The Journey of Natty Gann", "Jeremy Kagan", 101.0, null, 9700000.0, new DateTime(1985, 09, 27)),
            new WaltDisneyMovies("One Magic Christmas", "Phillip Borsos", 89.0, null, 13000000.0, new DateTime(1985, 11, 22)),
            new WaltDisneyMovies("The Great Mouse Detective", "John Musker", 74.0, 14000000.0, 38700000.0, new DateTime(1986, 07, 02)),
            new WaltDisneyMovies("Flight of the Navigator", "Randal Kleiser", 90.0, 9000000.0, 18564613.0, new DateTime(1986, 08, 01)),
            new WaltDisneyMovies("Benji the Hunted", "Joe Camp", 89.0, null, 22300000.0, new DateTime(1987, 06, 05)),
            new WaltDisneyMovies("The Man from Snowy River II", "Geoff Burrowes", 110.0, 8700000.0, 13687027.0, new DateTime(1988, 03, 24)),
            new WaltDisneyMovies("Oliver & Company", "George Scribner", 74.0, 31000000.0, 121000000.0, new DateTime(1988, 11, 18)),
            new WaltDisneyMovies("Honey, I Shrunk the Kids", "Joe Johnston", 93.0, 18000000.0, 222700000.0, new DateTime(1989, 06, 23)),
            new WaltDisneyMovies("Cheetah", "Jeff Blyth", 84.0, 5000000.0, 8153677.0, new DateTime(1989, 08, 18)),
            new WaltDisneyMovies("The Little Mermaid", "Ron Clements", 83.0, 40000000.0, null, new DateTime(1989, 11, 17)),
            new WaltDisneyMovies("DuckTales the Movie: Treasure of the Lost Lamp", "Bob Hathcock", 74.0, 20000000.0, 18100000.0, new DateTime(1990, 08, 03)),
            new WaltDisneyMovies("The Rescuers Down Under", "Mike Gabriel", 77.0, null, 47400000.0, new DateTime(1990, 11, 16)),
            new WaltDisneyMovies("White Fang", "Randal Kleiser", 107.0, 14000000.0, 34800000.0, new DateTime(1991, 01, 18)),
            new WaltDisneyMovies("Shipwrecked", "Nils Gaup", 93.0, 8700000.0, 15100000.0, new DateTime(1990, 10, 03)),
            new WaltDisneyMovies("Wild Hearts Can't Be Broken", "Steve Miner", 88.0, null, 7300000.0, new DateTime(1991, 05, 24)),
            new WaltDisneyMovies("The Rocketeer", "Joe Johnston", 108.0, 35000000.0, 46700000.0, new DateTime(1991, 06, 21)),
            new WaltDisneyMovies("Beauty and the Beast", "Gary Trousdale", 84.0, 25000000.0, 440100000.0, new DateTime(1991, 09, 29)),
            new WaltDisneyMovies("Newsies", "Kenny Ortega", 121.0, 15000000.0, 2800000.0, new DateTime(1992, 04, 10)),
            new WaltDisneyMovies("Honey, I Blew Up the Kid", "Randal Kleiser", 89.0, 40000000.0, 96000000.0, new DateTime(1992, 07, 17)),
            new WaltDisneyMovies("The Mighty Ducks", "Stephen Herek", 104.0, 14000000.0, 50800000.0, new DateTime(1992, 10, 02)),
            new WaltDisneyMovies("Aladdin", "Ron Clements", 90.0, 28000000.0, 504100000.0, new DateTime(1992, 11, 25)),
            new WaltDisneyMovies("The Muppet Christmas Carol", "Brian Henson", 86.0, 12000000.0, 27200000.0, new DateTime(1992, 12, 11)),
            new WaltDisneyMovies("Homeward Bound: The Incredible Journey", "Duwayne Dunham", 84.0, null, 57000000.0, new DateTime(1993, 02, 03)),
            new WaltDisneyMovies("A Far Off Place", "Mikael Salomon", 108.0, null, 12900000.0, new DateTime(1993, 03, 12)),
            new WaltDisneyMovies("The Adventures of Huck Finn", "Stephen Sommers", 107.0, 6500000.0, 24100000.0, new DateTime(1993, 04, 02)),
            new WaltDisneyMovies("Hocus Pocus", "Kenny Ortega", 96.0, 28000000.0, 44900000.0, new DateTime(1993, 07, 16)),
            new WaltDisneyMovies("Cool Runnings", "Jon Turteltaub", 98.0, 17000000.0, 154900000.0, new DateTime(1993, 10, 01)),
            new WaltDisneyMovies("The Three Musketeers", "Stephen Herek", 105.0, 30000000.0, 53900000.0, new DateTime(1993, 11, 12)),
            new WaltDisneyMovies("Iron Will", "Charles Haid", 108.0, null, 21000000.0, new DateTime(1994, 01, 14)),
            new WaltDisneyMovies("Blank Check", "Rupert Wainwright", 94.0, 13000000.0, 39000000.0, new DateTime(1994, 02, 11)),
            new WaltDisneyMovies("D2: The Mighty Ducks", "Sam Weisman", 106.0, null, 45600000.0, new DateTime(1994, 04, 17)),
            new WaltDisneyMovies("White Fang 2: Myth of the White Wolf", "Ken Olin", 102.0, null, 8878839.0, new DateTime(1994, 04, 14)),
            new WaltDisneyMovies("The Lion King", "Rob Minkoff", 88.0, 45000000.0, 968500000.0, new DateTime(1994, 06, 15)),
            new WaltDisneyMovies("Angels in the Outfield", "William Dear", 102.0, 31000000.0, 50200000.0, new DateTime(1994, 07, 15)),
            new WaltDisneyMovies("Squanto: A Warrior's Tale", "Xavier Koller", 102.0, null, 3337685.0, new DateTime(1994, 10, 28)),
            new WaltDisneyMovies("The Santa Clause", "John Pasquin", 97.0, 22000000.0, 189800000.0, new DateTime(1994, 11, 11)),
            new WaltDisneyMovies("Rudyard Kipling's The Jungle Book", "Stephen Sommers", 111.0, 30000000.0, 43200000.0, new DateTime(1994, 12, 25)),
            new WaltDisneyMovies("Heavyweights", "Steven Brill", 100.0, null, 17600000.0, new DateTime(1995, 02, 17)),
            new WaltDisneyMovies("Man of the House", "James Orr", 96.0, 22000000.0, 40070995.0, new DateTime(1995, 03, 03)),
            new WaltDisneyMovies("Tall Tale Jeremiah", "S. Chechik", 98.0, 32000000.0, 11000000.0, new DateTime(1995, 03, 24)),
            new WaltDisneyMovies("A Goofy Movie", "Kevin Lima", 78.0, 18000000.0, 37600000.0, new DateTime(1995, 04, 07)),
            new WaltDisneyMovies("Pocahontas", "Eric Goldberg", 81.0, 55000000.0, 346100000.0, new DateTime(1995, 06, 10)),
            new WaltDisneyMovies("Operation Dumbo Drop", "Simon Wincer", 108.0, 24000000.0, 24670346.0, new DateTime(1995, 07, 28)),
            new WaltDisneyMovies("A Kid in King Arthur's Court", "Michael Gottlieb", 89.0, 15000000.0, 13400000.0, new DateTime(1995, 08, 11)),
            new WaltDisneyMovies("The Big Green Holly", "Goldberg Sloan", 99.0, 12000000.0, 17700000.0, new DateTime(1995, 09, 28)),
            new WaltDisneyMovies("Frank and Ollie", "Theodore Thomas", 89.0, null, 0.0, new DateTime(1995, 01, 22)),
            new WaltDisneyMovies("Toy Story", "John Lasseter", 81.0, 30000000.0, 373000000.0, new DateTime(1995, 11, 19)),
            new WaltDisneyMovies("Tom and Huck", "Peter Hewitt", 92.0, null, 23900000.0, new DateTime(1995, 12, 22)),
            new WaltDisneyMovies("Muppet Treasure Island", "Brian Henson", 100.0, 31000000.0, 34300000.0, new DateTime(1996, 02, 16)),
            new WaltDisneyMovies("Homeward Bound II: Lost in San Francisco David", "R. Ellis", 89.0, null, 32700000.0, new DateTime(1996, 03, 08)),
            new WaltDisneyMovies("James and the Giant Peach", "Henry Selick", 79.0, 38000000.0, 37700000.0, new DateTime(1996, 04, 12)),
            new WaltDisneyMovies("The Hunchback of Notre Dame", "Kirk Wise", 91.0, 70000000.0, 325300000.0, new DateTime(1996, 06, 21)),
            new WaltDisneyMovies("First Kid David", "j. Evans", 101.0, 15000000.0, 26465920.0, new DateTime(1996, 08, 30)),
            new WaltDisneyMovies("D3: The Mighty Ducks", "Robert Lieberman", 104.0, null, 22900000.0, new DateTime(1996, 10, 04)),
            new WaltDisneyMovies("101 Dalmatians", "Stephen Herek", 103.0, 67000000.0, 320700000.0, new DateTime(1996, 11, 27)),
            new WaltDisneyMovies("That Darn Cat", "Bob Spiers", 86.0, null, 18300000.0, new DateTime(1997, 02, 14)),
            new WaltDisneyMovies("Jungle 2 Jungle", "John Pasquin", 105.0, 32000000.0, 59900000.0, new DateTime(1997, 03, 07)),
            new WaltDisneyMovies("Hercules", "John Musker", 93.0, 85000000.0, 252700000.0, new DateTime(1997, 06, 13)),
            new WaltDisneyMovies("George of the Jungle", "Sam Weisman", 92.0, 55000000.0, 174400000.0, new DateTime(1997, 07, 16)),
            new WaltDisneyMovies("Air Bud Charles", "Martin Smith", 98.0, 3000000.0, 27800000.0, new DateTime(1997, 08, 01)),
            new WaltDisneyMovies("RocketMan", "Stuart Gillard", 95.0, 16000000.0, 15400000.0, new DateTime(1997, 10, 10)),
            new WaltDisneyMovies("Flubber", "Les Mayfield", 93.0, 80000000.0, 178000000.0, new DateTime(1997, 11, 16)),
            new WaltDisneyMovies("Mr. Magoo", "Stanley Tong", 87.0, 30000000.0, 28900000.0, new DateTime(1997, 12, 25)),
            new WaltDisneyMovies("Meet the Deedles", "Steve Boyum", 93.0, 24000000.0, 4400000.0, new DateTime(1998, 03, 27)),
            new WaltDisneyMovies("Mulan", "Tony Bancroft", 87.0, 90000000.0, 304300000.0, new DateTime(1998, 06, 19)),
            new WaltDisneyMovies("The Parent Trap", "Nancy Meyers", 128.0, 15000000.0, 92100000.0, new DateTime(1998, 07, 29)),
            new WaltDisneyMovies("I'll Be Home for Christmas", "Arlene Sanford", 86.0, 30000000.0, 12200000.0, new DateTime(1998, 11, 13)),
            new WaltDisneyMovies("A Bug's Life", "John Lasseter", 95.0, 120000000.0, 363300000.0, new DateTime(1998, 11, 20)),
            new WaltDisneyMovies("Mighty Joe Young", "Ron Underwood", 114.0, 90000000.0, 50600000.0, new DateTime(1998, 12, 25)),
            new WaltDisneyMovies("My Favorite Martian", "Donald Petrie", 93.0, 65000000.0, 36800000.0, new DateTime(1999, 02, 12)),
            new WaltDisneyMovies("Doug's 1st Movie", "Maurice Joyce", 83.0, 5000000.0, 19400000.0, new DateTime(1999, 03, 26)),
            new WaltDisneyMovies("Endurance", "Bud Greenspan", 83.0, null, 0.0, new DateTime(1999, 05, 14)),
            new WaltDisneyMovies("Tarzan", "Chris Buck", 88.0, 130000000.0, 448200000.0, new DateTime(1999, 06, 12)),
            new WaltDisneyMovies("Inspector Gadget", "David Kellogg", 78.0, 75000000.0, 134400000.0, new DateTime(1999, 07, 23)),
            new WaltDisneyMovies("The Straight Story", "David Lynch", 112.0, 10000000.0, 6200000.0, new DateTime(2000, 01, 01)),
            new WaltDisneyMovies("Toy Story 2", "John Lasseter", 92.0, 90000000.0, 497400000.0, new DateTime(1999, 11, 13)),
            new WaltDisneyMovies("Fantasia 2000", "Don Hahn", 74.0, 85000000.0, 90900000.0, new DateTime(1999, 12, 17)),
            new WaltDisneyMovies("The Tigger Movie", "Jun Falkenstein", 78.0, 15000000.0, 96200000.0, new DateTime(2000, 02, 11)),
            new WaltDisneyMovies("Whispers: An Elephant's Tale", "Dereck Joubert", 72.0, 4000000.0, 500000.0, new DateTime(2000, 03, 10)),
            new WaltDisneyMovies("Dinosaur", "Eric Leighton", 82.0, 127500000.0, 349800000.0, new DateTime(2000, 05, 19)),
            new WaltDisneyMovies("Disney's The Kid", "Jon Turteltaub", 104.0, 65000000.0, 110300000.0, new DateTime(2000, 07, 07)),
            new WaltDisneyMovies("Remember the Titans", "Boaz Yakin", 113.0, 30000000.0, 136800000.0, new DateTime(2000, 09, 29)),
            new WaltDisneyMovies("102 Dalmatians", "Kevin Lima", 100.0, 85000000.0, 183600000.0, new DateTime(2000, 11, 22)),
            new WaltDisneyMovies("The Emperor's New Groove", "Mark Dindal", 78.0, 100000000.0, 169600000.0, new DateTime(2000, 12, 15)),
            new WaltDisneyMovies("Recess: School's Out", "Chuck Sheetz", 83.0, 23000000.0, 44500000.0, new DateTime(2001, 02, 10)),
            new WaltDisneyMovies("Atlantis: The Lost Empire", "Kirk Wise", 96.0, 90000000.0, 186100000.0, new DateTime(2001, 06, 03)),
            new WaltDisneyMovies("The Princess Diaries", "Garry Marshall", 115.0, 26000000.0, 165300000.0, new DateTime(2001, 07, 29)),
            new WaltDisneyMovies("Max Keeble's Big Move", "Tim Hill", 86.0, 25000000.0, 18600000.0, new DateTime(2001, 10, 05)),
            new WaltDisneyMovies("Monsters, Inc.", "Pete Docter", 92.0, 115000000.0, 577400000.0, new DateTime(2001, 10, 28)),
            new WaltDisneyMovies("Snow Dogs", "Brian Levant", 99.0, 33000000.0, 115000000.0, new DateTime(2002, 01, 18)),
            new WaltDisneyMovies("Return to Never Land", "Robin Budd", 73.0, 20000000.0, 115100000.0, new DateTime(2002, 02, 10)),
            new WaltDisneyMovies("The Rookie John", "Lee Hancock", 128.0, 22000000.0, 80700000.0, new DateTime(2002, 03, 29)),
            new WaltDisneyMovies("Lilo & Stitch", "Dean DeBlois", 85.0, 80000000.0, 273100000.0, new DateTime(2002, 06, 21)),
            new WaltDisneyMovies("The Country Bears", "Peter Hastings", 88.0, 35000000.0, 18000000.0, new DateTime(2002, 07, 21)),
            new WaltDisneyMovies("Spirited Away", "Hayao Miyazaki", 125.0, 15000000.0, null, new DateTime(2001, 07, 20)),
            new WaltDisneyMovies("Tuck Everlasting", "Jay Russell", 96.0, 15000000.0, 19300000.0, new DateTime(2002, 10, 11)),
            new WaltDisneyMovies("The Santa Clause 2", "Michael Lembeck", 104.0, 65000000.0, 172900000.0, new DateTime(2002, 11, 01)),
            new WaltDisneyMovies("Treasure Planet", "John Musker", 95.0, 140000000.0, 109600000.0, new DateTime(2002, 11, 27)),
            new WaltDisneyMovies("The Jungle Book 2", "Steve Trenbirth", 72.0, 20000000.0, 135700000.0, new DateTime(2003, 02, 14)),
            new WaltDisneyMovies("Piglet's Big Movie", "Francis Glebas", 75.0, 46000000.0, 62900000.0, new DateTime(2003, 03, 16)),
            new WaltDisneyMovies("Ghosts of the Abyss", "James Cameron", 61.0, 13000000.0, 28700000.0, new DateTime(2003, 03, 31)),
            new WaltDisneyMovies("Holes", "Andrew Davis", 117.0, 20000000.0, 71400000.0, new DateTime(2003, 04, 18)),
            new WaltDisneyMovies("The Lizzie McGuire Movie", "Jim Fall", 94.0, 17000000.0, 55500000.0, new DateTime(2003, 05, 02)),
            new WaltDisneyMovies("Finding Nemo", "Andrew Stanton", 100.0, 94000000.0, 940300000.0, new DateTime(2003, 05, 30)),
            new WaltDisneyMovies("Pirates of the Caribbean: The Curse of the Black Pearl", "Gore Verbinski", 143.0, 140000000.0, 654300000.0, new DateTime(2003, 06, 28)),
            new WaltDisneyMovies("Freaky Friday", "Mark Waters", 97.0, 26000000.0, 160800000.0, new DateTime(2003, 08, 04)),
            new WaltDisneyMovies("Brother Bear", "Aaron Blaise", 85.0, 46000000.0, 250400000.0, new DateTime(2003, 11, 01)),
            new WaltDisneyMovies("The Haunted Mansion", "Rob Minkoff", 86.0, 90000000.0, 182300000.0, new DateTime(2003, 11, 26)),
            new WaltDisneyMovies("The Young Black Stallion", "Simon Wincer", 50.0, null, 9638389.0, new DateTime(2003, 12, 25)),
            new WaltDisneyMovies("Teacher's Pet", "Timothy Barklund", 74.0, 10000000.0, 6500000.0, new DateTime(2004, 01, 16)),
            new WaltDisneyMovies("Miracle Gavin", "O'Connor", 136.0, 28000000.0, 64500000.0, new DateTime(2004, 02, 20)),
            new WaltDisneyMovies("Confessions of a Teenage Drama Queen", "Sara Sugarman", 89.0, 15000000.0, 33100000.0, new DateTime(2004, 02, 17)),
            new WaltDisneyMovies("Home on the Range", "John Sanford", 76.0, 110000000.0, 145500000.0, new DateTime(2004, 04, 02)),
            new WaltDisneyMovies("Sacred Planet Hairul", "Salleh Askor", 40.0, null, 1108356.0, new DateTime(2004, 04, 22)),
            new WaltDisneyMovies("Around the World in 80 Days", "Frank Coraci", 120.0, 110000000.0, 72200000.0, new DateTime(2004, 06, 16)),
            new WaltDisneyMovies("America's Heart and Soul", "Louis Schwartzberg", 84.0, null, 314402.0, new DateTime(2004, 07, 02)),
            new WaltDisneyMovies("The Princess Diaries 2: Royal Engagement", "Garry Marshall", 113.0, 45000000.0, 134700000.0, new DateTime(2004, 08, 11)),
            new WaltDisneyMovies("The Incredibles", "Brad Bird", 115.0, 92000000.0, 633000000.0, new DateTime(2004, 10, 24)),
            new WaltDisneyMovies("National Treasure", "Jon Turteltaub", 131.0, 100000000.0, 347500000.0, new DateTime(2004, 11, 19)),
            new WaltDisneyMovies("Aliens of the Deep", "James Cameron", 100.0, null, 9000000.0, new DateTime(2005, 01, 28)),
            new WaltDisneyMovies("Pooh's Heffalump Movie", "Frank Nissen", 68.0, 20000000.0, 52900000.0, new DateTime(2005, 02, 11)),
            new WaltDisneyMovies("The Pacifier", "Adam Shankman", 95.0, 56000000.0, 198600000.0, new DateTime(2005, 03, 04)),
            new WaltDisneyMovies("Ice Princess", "Tim Fywell", 97.0, 25000000.0, 27600000.0, new DateTime(2005, 03, 18)),
            new WaltDisneyMovies("Herbie: Fully Loaded", "Angela Robinson", 101.0, 50000000.0, 144100000.0, new DateTime(2005, 06, 22)),
            new WaltDisneyMovies("Howl's Moving Castle", "Hayao Miyazaki", 119.0, null, 0.0, new DateTime(2004, 09, 05)),
            new WaltDisneyMovies("Sky High", "Mike Mitchell", 100.0, 35000000.0, 86400000.0, new DateTime(2005, 07, 29)),
            new WaltDisneyMovies("Valiant", "Gary Chapman", 76.0, 35000000.0, 61700000.0, new DateTime(2005, 03, 25)),
            new WaltDisneyMovies("The Greatest Game Ever Played", "Bill Paxton", 120.0, 25000000.0, 15400000.0, new DateTime(2005, 09, 30)),
            new WaltDisneyMovies("Chicken Little", "Mark Dindal", 81.0, 150000000.0, 314400000.0, new DateTime(2005, 10, 30)),
            new WaltDisneyMovies("The Chronicles of Narnia: The Lion, the Witch and the Wardrobe", "Andrew Adamson", 143.0, 180000000.0, 745000000.0, new DateTime(2005, 12, 07)),
            new WaltDisneyMovies("Glory Road", "James Gartner", 118.0, 30000000.0, 42900000.0, new DateTime(2006, 01, 13)),
            new WaltDisneyMovies("Roving Mars", "George Butler", 40.0, 1000000.0, 11000000.0, new DateTime(2006, 01, 27)),
            new WaltDisneyMovies("Eight Below", "Frank Marshall", 120.0, 40000000.0, 120500000.0, new DateTime(2006, 02, 17)),
            new WaltDisneyMovies("The Shaggy Dog", "Brian Robbins", 99.0, 50000000.0, 87100000.0, new DateTime(2006, 03, 10)),
            new WaltDisneyMovies("The Wild  Steve", "Spaz Williams", 82.0, 80000000.0, 102300000.0, new DateTime(2006, 04, 14)),
            new WaltDisneyMovies("Cars", "John Lasseter", 117.0, 120000000.0, 462000000.0, new DateTime(2006, 05, 26)),
            new WaltDisneyMovies("Pirates of the Caribbean: Dead Man's Chest", "Gore Verbinski", 150.0, 225000000.0, 1066000000.0, new DateTime(2006, 06, 24)),
            new WaltDisneyMovies("Invincible", "Ericson Core", 104.0, 30000000.0, 58500000.0, new DateTime(2006, 08, 25)),
            new WaltDisneyMovies("The Nightmare Before Christmas", "Henry Selick", 76.0, 24000000.0, 91500000.0, new DateTime(1993, 10, 29)),
            new WaltDisneyMovies("The Santa Clause 3: The Escape Clause", "Michael Lembeck", 92.0, 12000000.0, 110800000.0, new DateTime(2006, 11, 03)),
            new WaltDisneyMovies("Bridge to Terabithia", "Gabor Csupa", 95.0, 20000000.0, 137600000.0, new DateTime(2007, 02, 16)),
            new WaltDisneyMovies("Meet the Robinsons", "Stephen Anderson", 94.0, 150000000.0, 169300000.0, new DateTime(2007, 03, 23)),
            new WaltDisneyMovies("Pirates of the Caribbean: At World's End", "Gore Verbinski", 167.0, 300000000.0, 960900000.0, new DateTime(2007, 05, 19)),
            new WaltDisneyMovies("Ratatouille", "Brad Bird", 111.0, 150000000.0, 623700000.0, new DateTime(2007, 06, 22)),
            new WaltDisneyMovies("The Secret of the Magic Gourd", "John Chu", 85.0, null, 0.0, new DateTime(2007, 06, 29)),
            new WaltDisneyMovies("Underdog Frederik", "Du Chau", 82.0, 25000000.0, 65300000.0, new DateTime(2007, 08, 03)),
            new WaltDisneyMovies("The Pixar Story", "Leslie Iwerks", 87.0, null, 0.0, new DateTime(2007, 08, 28)),
            new WaltDisneyMovies("The Game Plan", "Andy Fickman", 110.0, 22000000.0, 146600000.0, new DateTime(2007, 09, 23)),
            new WaltDisneyMovies("Enchanted", "Kevin Lima", 107.0, 85000000.0, 340500000.0, new DateTime(2007, 10, 20)),
            new WaltDisneyMovies("National Treasure: Book of Secrets", "Jon Turteltaub", 124.0, 130000000.0, 459200000.0, new DateTime(2007, 12, 21)),
            new WaltDisneyMovies("College Road Trip", "Roger Kumble", 83.0, 25000000.0, 51500000.0, new DateTime(2008, 03, 07)),
            new WaltDisneyMovies("The Chronicles of Narnia: Prince Caspian", "Andrew Adamson", 150.0, 225000000.0, 419700000.0, new DateTime(2008, 05, 07)),
            new WaltDisneyMovies("WALL-E", "Andrew Stanton", 97.0, 180000000.0, 521300000.0, new DateTime(2008, 06, 23)),
            new WaltDisneyMovies("Beverly Hills Chihuahua", "Raja Gosnell", 91.0, 20000000.0, 149300000.0, new DateTime(2008, 10, 03)),
            new WaltDisneyMovies("Morning Light", "Mark Monroe", 100.0, null, 275776.0, new DateTime(2008, 10, 17)),
            new WaltDisneyMovies("High School Musical 3: Senior Year", "Kenny Ortega", 112.0, 11000000.0, 252900000.0, new DateTime(2008, 10, 17)),
            new WaltDisneyMovies("Roadside Romeo", "Jugal Hansraj", 93.0, null, 2000000.0, new DateTime(2008, 10, 23)),
            new WaltDisneyMovies("Bolt", "Chris Williams", 96.0, 150000000.0, 310000000.0, new DateTime(2008, 11, 21)),
            new WaltDisneyMovies("Bedtime Stories", "Adam Shankman", 99.0, 80000000.0, 212900000.0, new DateTime(2008, 12, 25)),
            new WaltDisneyMovies("Jonas Brothers: The 3D Concert Experience", "Bruce Hendricks", 76.0, null, 23100000.0, new DateTime(2009, 02, 27)),
            new WaltDisneyMovies("Race to Witch Mountain", "Andy Fickman", 98.0, 50000000.0, 106400000.0, new DateTime(2009, 03, 11)),
            new WaltDisneyMovies("Hannah Montana: The Movie", "Peter Chelsom", 97.0, 30000000.0, 170000000.0, new DateTime(2009, 04, 10)),
            new WaltDisneyMovies("Earth", "Mark Linfield", 99.0, 47000000.0, 109000000.0, new DateTime(2007, 10, 10)),
            new WaltDisneyMovies("Up", "Pete Docter", 96.0, 175000000.0, 735100000.0, new DateTime(2009, 05, 29)),
            new WaltDisneyMovies("G-Force Hoyt H.", "Yeatman Jr.", 90.0, 150000000.0, 292800000.0, new DateTime(2009, 07, 24)),
            new WaltDisneyMovies("Ponyo", "Hayao Miyazaki", 101.0, null, 0.0, new DateTime(2008, 07, 19)),
            new WaltDisneyMovies("A Christmas Carol", "Robert Zemeckis", 96.0, 175000000.0, 325000000.0, new DateTime(2009, 11, 03)),
            new WaltDisneyMovies("Old Dogs", "Walt Becker", 88.0, 35000000.0, 96800000.0, new DateTime(2009, 11, 25)),
            new WaltDisneyMovies("The Princess and the Frog", "John Musker", 97.0, 105000000.0, 271000000.0, new DateTime(2009, 11, 25)),
            new WaltDisneyMovies("Alice in Wonderland", "Tim Burton", 108.0, 200000000.0, 102500000.0, new DateTime(2010, 02, 25)),
            new WaltDisneyMovies("Oceans", "Jacques Perrin", 104.0, 80000000.0, 82700000.0, new DateTime(2009, 10, 17)),
            new WaltDisneyMovies("Prince of Persia: The Sands of Time", "Mike Newell", 116.0, 150000000.0, 336400000.0, new DateTime(2010, 05, 09)),
            new WaltDisneyMovies("Toy Story 3", "Lee Unkrich", 103.0, 200000000.0, 1067000000.0, new DateTime(2010, 06, 12)),
            new WaltDisneyMovies("The Sorcerer's Apprentice", "Jon Turteltaub", 109.0, 150000000.0, 215300000.0, new DateTime(2010, 07, 08)),
            new WaltDisneyMovies("Tales from Earthsea", "Gori Miyazaki", 115.0, 22000000.0, null, new DateTime(2006, 07, 29)),
            new WaltDisneyMovies("The Crimson Wing: Mystery of the Flamingos", "Leander Ward", 74.0, null, 0.0, new DateTime(2008, 10, 26)),
            new WaltDisneyMovies("Secretariat", "Randall Wallace", 123.0, 35000000.0, 60300000.0, new DateTime(2010, 09, 30)),
            new WaltDisneyMovies("Do Dooni Chaar", "Habib Faisal", 108.0, null, 0.0, new DateTime(2010, 10, 08)),
            new WaltDisneyMovies("Tangled", "Nathan Greno", 100.0, 260000000.0, 592400000.0, new DateTime(2010, 11, 14)),
            new WaltDisneyMovies("The Boys: The Sherman Brothers' Story Jeffrey", "C. Sherman", 101.0, null, 55513.0, new DateTime(2009, 04, 24)),
            new WaltDisneyMovies("Tron: Legacy", "Joseph Kosinski", 125.0, 170000000.0, 400100000.0, new DateTime(2010, 11, 30)),
            new WaltDisneyMovies("Anaganaga O", "Dheerudu Prakash Kovelamudi", 100.0, 3800000.0, 7000000.0, new DateTime(2011, 01, 14)),
            new WaltDisneyMovies("Lilly the Witch: The Journey to Mandolan", "Harald Sicheritz", 90.0, null, 0.0, new DateTime(2011, 02, 17)),
            new WaltDisneyMovies("Mars Needs Moms", "Simon Wells", 88.0, 150000000.0, 39200000.0, new DateTime(2011, 03, 11)),
            new WaltDisneyMovies("Zokkomon", "Satyajit Bhatkal", 109.0, null, 0.0, new DateTime(2011, 04, 22)),
            new WaltDisneyMovies("African Cats", "Keith Scholey", 89.0, 5000000.0, 30900000.0, new DateTime(2011, 04, 22)),
            new WaltDisneyMovies("Prom", "Joe Nussbaum", 104.0, 8000000.0, 10700000.0, new DateTime(2011, 04, 29)),
            new WaltDisneyMovies("Pirates of the Caribbean: On Stranger Tides", "Rob Marshall", 137.0, 410600000.0, 1046000000.0, new DateTime(2011, 05, 07)),
            new WaltDisneyMovies("Cars 2", "John Lasseter", 106.0, 200000000.0, 562100000.0, new DateTime(2011, 06, 18)),
            new WaltDisneyMovies("Winnie the Pooh", "Stephen Anderson", 63.0, 30000000.0, 50100000.0, new DateTime(2011, 04, 06)),
            new WaltDisneyMovies("The Muppets", "James Bobin", 103.0, 45000000.0, 165200000.0, new DateTime(2011, 11, 04)),
            new WaltDisneyMovies("Arrietty", "Hiromasa Yonebayashi", 95.0, 23000000.0, 146000000.0, new DateTime(2010, 07, 17)),
            new WaltDisneyMovies("John Carter", "Andrew Stanton", 132.0, 306600000.0, 284100000.0, new DateTime(2012, 02, 22)),
            new WaltDisneyMovies("Chimpanzee", "Mark Linfield", 77.0, 5000000.0, 34800000.0, new DateTime(2012, 04, 20)),
            new WaltDisneyMovies("Arjun: The Warrior Prince", "Arnab Chaudhuri", 96.0, null, 0.0, new DateTime(2012, 05, 25)),
            new WaltDisneyMovies("Brave", "Brenda Chapman", 93.0, 185000000.0, 540400000.0, new DateTime(2012, 06, 10)),
            new WaltDisneyMovies("The Odd Life of Timothy Green", "Peter Hedges", 104.0, 25000000.0, 56000000.0, new DateTime(2012, 08, 15)),
            new WaltDisneyMovies("Frankenweenie", "Tim Burton", 87.0, 39000000.0, 81500000.0, new DateTime(2012, 09, 20)),
            new WaltDisneyMovies("Wreck-It Ralph", "Rich Moore", 101.0, 165000000.0, 471200000.0, new DateTime(2012, 10, 29)),
            new WaltDisneyMovies("Oz the Great and Powerful", "Sam Raimi", 130.0, 200000000.0, 493300000.0, new DateTime(2013, 02, 14)),
            new WaltDisneyMovies("Wings of Life", "Louis Schwartzberg", 77.0, null, 0.0, new DateTime(2011, 03, 16)),
            new WaltDisneyMovies("Monsters University", "Dan Scanlon", 104.0, 200000000.0, 743600000.0, new DateTime(2013, 06, 05)),
            new WaltDisneyMovies("The Lone Ranger", "Gore Verbinski", 150.0, 225000000.0, 260500000.0, new DateTime(2013, 06, 22)),
            new WaltDisneyMovies("Planes", "Klay Hall", 92.0, 50000000.0, 239300000.0, new DateTime(2013, 08, 02)),
            new WaltDisneyMovies("Frozen", "Jennifer Lee", 102.0, 150000000.0, 1280000000.0, new DateTime(2013, 11, 19)),
            new WaltDisneyMovies("Saving Mr. Banks  John", "Lee Hancock", 125.0, 35000000.0, 117900000.0, new DateTime(2013, 10, 20)),
            new WaltDisneyMovies("Muppets Most Wanted", "James Bobin", 107.0, 51000000.0, 80400000.0, new DateTime(2014, 03, 11)),
            new WaltDisneyMovies("Bears", "Keith Scholey", 77.0, 5000000.0, 21300000.0, new DateTime(2014, 04, 18)),
            new WaltDisneyMovies("Million Dollar Arm", "Craig Gillespie", 124.0, 25000000.0, 40200000.0, new DateTime(2014, 05, 06)),
            new WaltDisneyMovies("Maleficent", "Robert Stromberg", 97.0, 180000000.0, 758500000.0, new DateTime(2014, 05, 28)),
            new WaltDisneyMovies("Planes: Fire & Rescue", "Bobs Gannaway", 84.0, 50000000.0, 147000000.0, new DateTime(2014, 07, 15)),
            new WaltDisneyMovies("Khoobsurat", "Shashanka Ghosh", 127.0, 3200000.0, 11000000.0, new DateTime(2014, 09, 19)),
            new WaltDisneyMovies("Alexander and the Terrible, Horrible, No Good, Very Bad Day", "Miguel Arteta", 81.0, 28000000.0, 100700000.0, new DateTime(2014, 10, 06)),
            new WaltDisneyMovies("Big Hero 6", "Chris Williams", 102.0, 165000000.0, 657900000.0, new DateTime(2014, 10, 23)),
            new WaltDisneyMovies("Into the Woods", "Rob Marshall", 124.0, 50000000.0, 212900000.0, new DateTime(2014, 12, 08)),
            new WaltDisneyMovies("McFarland, USA", "Niki Caro", 129.0, 17000000.0, 45700000.0, new DateTime(2015, 02, 09)),
            new WaltDisneyMovies("Cinderella", "Kenneth Branagh", 106.0, 84210000.0, 542400000.0, new DateTime(2015, 02, 13)),
            new WaltDisneyMovies("Monkey Kingdom", "Alastair Fothergill", 82.0, 5000000.0, 17100000.0, new DateTime(2015, 04, 17)),
            new WaltDisneyMovies("Tomorrowland", "Brad Bird", 130.0, 180000000.0, 209000000.0, new DateTime(2015, 05, 09)),
            new WaltDisneyMovies("Inside Out", "Pete Docter", 95.0, 175000000.0, 858800000.0, new DateTime(2015, 05, 18)),
            new WaltDisneyMovies("ABCD 2 Remo", "D'Souza", 154.0, null, 0.0, new DateTime(2015, 06, 19)),
            new WaltDisneyMovies("The Good Dinosaur", "Peter Sohn", 97.0, 175000000.0, 332200000.0, new DateTime(2015, 11, 10)),
            new WaltDisneyMovies("The Finest Hours", "Craig Gillespie", 117.0, 70000000.0, 52100000.0, new DateTime(2016, 01, 25)),
            new WaltDisneyMovies("Zootopia", "Rich Moore", 108.0, 150000000.0, 1024000000.0, new DateTime(2016, 02, 13)),
            new WaltDisneyMovies("The Jungle Book", "Jon Favreau", 106.0, 175000000.0, 966600000.0, new DateTime(2016, 04, 04)),
            new WaltDisneyMovies("Tini: The Movie Juan", "Pablo Buscarini", 98.0, null, 17000000.0, new DateTime(2016, 04, 23)),
            new WaltDisneyMovies("Alice Through the Looking Glass", "James Bobin", 113.0, 170000000.0, 299500000.0, new DateTime(2016, 05, 10)),
            new WaltDisneyMovies("Finding Dory", "Andrew Stanton", 97.0, 175000000.0, 1030000000.0, new DateTime(2016, 06, 08)),
            new WaltDisneyMovies("The BFG", "Steven Spielberg", 118.0, 140000000.0, 195200000.0, new DateTime(2016, 05, 14)),
            new WaltDisneyMovies("Pete's Dragon", "David Lowery", 103.0, 65000000.0, 143700000.0, new DateTime(2016, 08, 08)),
            new WaltDisneyMovies("Queen of Katwe", "Mira Nair", 124.0, 15000000.0, 10400000.0, new DateTime(2016, 09, 10)),
            new WaltDisneyMovies("Moana", "Ron Clements", 107.0, 150000000.0, 645000000.0, new DateTime(2016, 11, 14)),
            new WaltDisneyMovies("Dangal", "Nitesh Tiwari", 161.0, null, 0.0, new DateTime(2016, 12, 21)),
            new WaltDisneyMovies("March of the Penguins", "Luc Jacquet", 80.0, 8000000.0, 127400000.0, new DateTime(2005, 01, 26)),
            new WaltDisneyMovies("Beauty and the Beast", "Bill Condon", 129.0, 160000000.0, 1264000000.0, new DateTime(2017, 02, 23)),
            new WaltDisneyMovies("Born in China", "Lu Chuan", 76.0, 5000000.0, 25100000.0, new DateTime(2016, 08, 12)),
            new WaltDisneyMovies("Pirates of the Caribbean: Dead Men Tell No Tales", "Espen Sandberg", 129.0, 230000000.0, 794900000.0, new DateTime(2017, 05, 11)),
            new WaltDisneyMovies("Cars 3", "Brian Fee", 102.0, 175000000.0, 383900000.0, new DateTime(2017, 05, 23)),
            new WaltDisneyMovies("Ghost of the Mountains", "Ben Wallis", 105.0, null, 0.0, new DateTime(2017, 06, 30)),
            new WaltDisneyMovies("Jagga Jasoos", "Anurag Basu", 162.0, null, 0.0, new DateTime(2017, 07, 14)),
            new WaltDisneyMovies("The Last Knight", "Dmitriy Dyachenko", 114.0, 8000000.0, 30500000.0, new DateTime(2017, 10, 29)),
            new WaltDisneyMovies("Coco", "Lee Unkrich", 105.0, 175000000.0, 807800000.0, new DateTime(2017, 10, 20)),
            new WaltDisneyMovies("A Wrinkle in Time", "Ava DuVernay", 109.0, 100000000.0, 133400000.0, new DateTime(2018, 02, 26)),
            new WaltDisneyMovies("Incredibles 2", "Brad Bird", 118.0, 200000000.0, 1245000000.0, new DateTime(2018, 06, 05)),
            new WaltDisneyMovies("Christopher Robin", "Marc Forster", 104.0, 65000000.0, 197700000.0, new DateTime(2018, 07, 30)),
            new WaltDisneyMovies("The Nutcracker and the Four Realms", "Joe Johnston", 99.0, 120000000.0, 174000000.0, new DateTime(2018, 10, 29)),
            new WaltDisneyMovies("Ralph Breaks the Internet", "Phil Johnston", 112.0, 175000000.0, 529200000.0, new DateTime(2018, 11, 05)),
            new WaltDisneyMovies("Mary Poppins Returns", "Rob Marshall", 131.0, 130000000.0, 349500000.0, new DateTime(2018, 11, 29)),
            new WaltDisneyMovies("Dumbo", "Tim Burton", 112.0, 170000000.0, 353300000.0, new DateTime(2019, 03, 11)),
            new WaltDisneyMovies("Aladdin", "Guy Ritchie", 128.0, 183000000.0, null, new DateTime(2019, 05, 08)),
            new WaltDisneyMovies("Toy Story 4", "Josh Cooley", 100.0, 200000000.0, 1073000000.0, new DateTime(2019, 06, 11)),
            new WaltDisneyMovies("The Lion King", "Jon Favreau", 118.0, 250000000.0, 1657000000.0, new DateTime(2019, 07, 09)),
            new WaltDisneyMovies("Maleficent: Mistress of Evil", "Joachim Running", 119.0, 185000000.0, 491700000.0, new DateTime(2019, 10, 18)),
            new WaltDisneyMovies("Lady and the Tramp", "Charlie Bean", 104.0, 60000000.0, null, new DateTime(2019, 11, 12)),
            new WaltDisneyMovies("Noelle", "Marc Lawrence", 100.0, null, 0.0, new DateTime(2019, 11, 12)),
            new WaltDisneyMovies("Frozen II", "Jennifer Lee", 103.0, 150000000.0, 1450000000.0, new DateTime(2019, 11, 07)),
            new WaltDisneyMovies("Togo", "Ericson Core", 114.0, 40000000.0, null, new DateTime(2019, 12, 20)),
            new WaltDisneyMovies("Timmy Failure: Mistakes Were Made", "Tom McCarthy", 99.0, 42000000.0, null, new DateTime(2020, 01, 25)),
            new WaltDisneyMovies("Onward", "Dan Scanlon", 102.0, 175000000.0, 141900000.0, new DateTime(2020, 02, 21))
        };

        public class WaltDisneyMovies
        {
            public string Title { get; set; }
            public string DirectedBy { get; set; }
            public double? RunningTime { get; set; }
            public double? Budget { get; set; }
            public double? BoxOffice { get; set; }
            public DateTime ReleaseDate { get; set; }

            public WaltDisneyMovies(
                string title,
                string directedBy,
                double? runningTime,
                double? budget,
                double? boxOffice,
                DateTime releaseDate)
            {
                Title = title;
                DirectedBy = directedBy;
                RunningTime = runningTime;
                Budget = budget;
                BoxOffice = boxOffice;
                ReleaseDate = releaseDate;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1 : \n");
            var mov = new MovieCollection();
            var old =
                (from j in mov.Movies
                 orderby j.ReleaseDate ascending
                 select j).First();
            Console.WriteLine("{0}, is the oldest movie\n", old.Title);

            Console.WriteLine("\nQuestion 2 : \n");
            var total =
                (from j in mov.Movies
                 select j).Count();
            Console.WriteLine("{0}, is the number of movie\n", total);

            Console.WriteLine("\nQuestion 3 : \n");
            var buff =
                (from j in mov.Movies
                 where j.Title.Contains("e") == true
                 select j).Count();
            Console.WriteLine("Their are {0} with an e \n", buff);

            Console.WriteLine("\nQuestion 4 : \n");
            var d =
                (from j in mov.Movies
                 select j.Title.Count(f => f == 'f')).Sum();
            Console.WriteLine("Their are {0} ,f in the movie name \n", d);

            Console.WriteLine("\nQuestion 5 : \n");
            var budget =
                (from j in mov.Movies
                 orderby j.Budget descending
                 select j).First();
            Console.WriteLine("{0}, is the movie with the biggest budget (${1})\n", budget.Title, budget.Budget);

            Console.WriteLine("\nQuestion 6 : \n");
            var Box_Office =
                (from j in mov.Movies
                 orderby j.BoxOffice ascending
                 where (j.BoxOffice != null && j.BoxOffice >1000)
                 select j).First();
            Console.WriteLine("{0}, have the lowest bo office (${1})\n", Box_Office.Title, Box_Office.BoxOffice);

            Console.WriteLine("\nQuestion 7 : \n");
            var onze =
                (from j in mov.Movies
                 orderby j.Title ascending
                 select j.Title).Take(11);
            int i = 0;
            Console.WriteLine("The 11 first are : \n");
            foreach (string j in onze)
            {
                Console.WriteLine("{0} - {1}\n", i, j);
                i++;
            }

            Console.WriteLine("\nQuestion 8 : \n");
            var before =
                (from j in mov.Movies
                where j.ReleaseDate < new DateTime(1980, 01, 01)
                select j).Count();

            Console.WriteLine("Their are {0} movie made before 1980\n", before);

            Console.WriteLine("\nQuestion 9 : \n");
            char[] vowels = new[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            var average =
                (from j in mov.Movies
                where vowels.Contains(j.Title[0])
                select j.RunningTime).Average();

            Console.WriteLine("The average running time is {0} for the movie with a vowel as the first letter \n", average);

            Console.WriteLine("\nQuestion 10 : \n");
            var buff2 =
                from j in mov.Movies
                where ((j.Title.ToLower().Contains('h') || j.Title.ToLower().Contains('w')) && ( j.Title.ToLower().Contains('i') == false || j.Title.ToLower().Contains('t') == false ))
                select j.Title;

            Console.WriteLine("The movies that contain letter 'H' or 'W' but not 'I' or 'T' : \n");
            i = 0;
            foreach (string j in buff2)
            {
                Console.WriteLine("{0} - {1}\n", i, j);
                i++;
            }
            Console.WriteLine("\n");

            Console.WriteLine("\nQuestion 11 : \n");
            var BOB =
                (from j in mov.Movies
                where (j.BoxOffice != null && j.Budget != null && (j.Budget / j.BoxOffice) < 50 )
                select (j.Budget / j.BoxOffice)).Average();

            Console.WriteLine("The mean of all Budget every movie ever is {0} ", BOB);

            Console.WriteLine("\nQuestion 12 : \n");
            var stronger =
                from j in (from j in mov.Movies
                           group j.Title by j.Title.Length into newgroup
                           select newgroup)
                orderby j.Key ascending
                select j;

           
            foreach (var j in stronger)
            {
                Console.WriteLine("{0}  => {1}  \n", j.Key, j.Count());
            }

            Console.WriteLine("\nQuestion 12 : \n");
            var date =
                (from a in (from j in mov.Movies
                            where (j.BoxOffice != null && j.Budget != null)
                            group (j.Budget/j.BoxOffice) by j.ReleaseDate.Year into newgroup
                            select newgroup)
                orderby a.Key ascending
                select a);

            Console.WriteLine("Mean of all Budget every movie grouped by yearly: \n");
            foreach (var j in date)
            {
                Console.WriteLine("{0} => ${1} \n", j.Key, j.Average());
            }


            Exercice2 exercice2 = new Exercice2();
            exercice2.skyofstar();

        }

    }

    public class Exercice2
    {
        private static Mutex mut = new Mutex();
        private const int numIterations = 1;
        private const int numThreads = 3;
        public static System.Threading.Timer timer1;

        public void skyofstar()
        {
           
            Thread espace = new Thread(new ThreadStart(() => ThreadProc(' ', 50))); 
            espace.Start();
            espace.Join(10000);

            Thread asterix = new Thread(new ThreadStart(() => ThreadProc('*', 40)));
            asterix.Start();
            asterix.Join(11000);

            Thread point = new Thread(new ThreadStart(() => ThreadProc('°',20)));
            point.Start();
            point.Join(9000);

            Thread.Sleep(11000);
            static void ThreadProc(char a, double period)
            {
                var start = TimeSpan.Zero;
                var periods = TimeSpan.FromMilliseconds(period);

                var timer = new System.Threading.Timer((e) =>
                {
                    UseResource(a);
                }, null, start, periods);
            }

            static void UseResource(char a)
            {
                mut.WaitOne();
                Console.Write(a);
                mut.ReleaseMutex();
            }
        }
    }
}

