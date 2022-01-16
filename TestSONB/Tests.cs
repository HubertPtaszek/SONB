using SONB;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestSONB
{
    public class Tests
    {


        [Fact]
        public void GroupTimes_GroupsShouldBe1()
        {
            var votingService = new Voting();
            votingService.s1.Time = new DateTime(2022, 1, 7, 17, 0, 0, 0);
            votingService.s2.Time = new DateTime(2022, 1, 7, 17, 0, 0, 0);
            votingService.s3.Time = new DateTime(2022, 1, 7, 17, 0, 0, 0);
            votingService.s4.Time = new DateTime(2022, 1, 7, 17, 0, 0, 0);
            votingService.s5.Time = new DateTime(2022, 1, 7, 17, 0, 0, 0);
            votingService.s6.Time = new DateTime(2022, 1, 7, 17, 0, 0, 0);

            votingService.epsilon = "2";
            votingService.GroupTimes();

            Assert.Single(votingService.groups);
        }

        [Fact]
        public void GroupTimes_GroupsShouldBe3()
        {
            var votingService = new Voting();
            votingService.s1.Time = new DateTime(2022, 1, 7, 17, 0, 0, 0);
            votingService.s2.Time = new DateTime(2022, 1, 7, 17, 0, 0, 2);
            votingService.s3.Time = new DateTime(2022, 1, 7, 17, 0, 0, 5);
            votingService.s4.Time = new DateTime(2022, 1, 7, 17, 0, 0, 7);
            votingService.s5.Time = new DateTime(2022, 1, 7, 17, 0, 0, 10);
            votingService.s6.Time = new DateTime(2022, 1, 7, 17, 0, 0, 12);

            votingService.epsilon = "002";
            votingService.GroupTimes();

            Assert.Equal(3, votingService.groups.Count);
        }
        [Fact]
        public void GroupTimes_GroupsShouldBe6()
        {
            var votingService = new Voting();
            votingService.s1.Time = new DateTime(2022, 1, 7, 17, 0, 0, 0);
            votingService.s2.Time = new DateTime(2022, 1, 7, 17, 0, 0, 3);
            votingService.s3.Time = new DateTime(2022, 1, 7, 17, 0, 0, 6);
            votingService.s4.Time = new DateTime(2022, 1, 7, 17, 0, 0, 9);
            votingService.s5.Time = new DateTime(2022, 1, 7, 17, 0, 0, 12);
            votingService.s6.Time = new DateTime(2022, 1, 7, 17, 0, 0, 18);

            votingService.epsilon = "002";
            votingService.GroupTimes();

            Assert.Equal(6, votingService.groups.Count);
        }

        [Fact]
        public void VotingMethod_GroupsShouldBeNull()
        {
            var votingService = new Voting();

            Assert.Null(votingService.VotingMethod());
        }

        [Fact]
        public void VotingMethod_GroupsShouldBeDefinedValue()
        {
            var votingService = new Voting();
            votingService.groups.Add(1, new ServerList<Server>() { 
                new Server() { 
                    Name = "S1", 
                    Weight = 10, 
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 0)
                },

            });
            votingService.groups.Add(2, new ServerList<Server>() {
                new Server() {
                    Name = "S2",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 5)
                },
                new Server() {
                    Name = "S3",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 6)
                },
                new Server() {
                    Name = "S4",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 7)
                },
                new Server() {
                    Name = "S5",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 8)
                },
                new Server() {
                    Name = "S6",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 9)
                },
            });

            DateTime expected = new DateTime(2022, 1, 7, 17, 0, 0, 0);
            Assert.Equal(expected.TimeOfDay, votingService.VotingMethod().Value.TimeOfDay);
        }

        [Fact]
        public void VotingMethod_GroupsShouldBeDefinedValue2()
        {
            var votingService = new Voting();
            votingService.groups.Add(1, new ServerList<Server>() {
                new Server() {
                    Name = "S1",
                    Weight = 10,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 0)
                },
                new Server() {
                    Name = "S2",
                    Weight = 10,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 2)
                },
            });
            votingService.groups.Add(2, new ServerList<Server>() {
                new Server() {
                    Name = "S3",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 6)
                },
                new Server() {
                    Name = "S4",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 7)
                },
                new Server() {
                    Name = "S5",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 8)
                },
                new Server() {
                    Name = "S6",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 9)
                },
            });

            DateTime expected = new DateTime(2022, 1, 7, 17, 0, 0, 1);
            Assert.Equal(expected.TimeOfDay, votingService.VotingMethod().Value.TimeOfDay);
        }

        [Fact]
        public void VotingMethod_GroupsShouldBeDefinedValue3()
        {
            var votingService = new Voting();
            votingService.groups.Add(1, new ServerList<Server>() {
                new Server() {
                    Name = "S1",
                    Weight = 10,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 0)
                },
            });
            votingService.groups.Add(2, new ServerList<Server>() {
                new Server() {
                    Name = "S2",
                    Weight = 5,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 5)
                },
                new Server() {
                    Name = "S3",
                    Weight = 5,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 6)
                },
            });
            votingService.groups.Add(3, new ServerList<Server>() {
                new Server() {
                    Name = "S4",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 7)
                },
                new Server() {
                    Name = "S5",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 8)
                },
                new Server() {
                    Name = "S6",
                    Weight = 1,
                    Time = new DateTime(2022, 1, 7, 17, 0, 0, 9)
                },
            });

            DateTime expected = new DateTime(2022, 1, 7, 17, 0, 0, 0);
            Assert.Equal(expected.TimeOfDay, votingService.VotingMethod().Value.TimeOfDay);
        }

    }
}
