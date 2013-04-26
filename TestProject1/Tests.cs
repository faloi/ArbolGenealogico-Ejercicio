using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ArbolGenealogico
{
    [TestClass]
    public class Test1
    {
        #region People

        #region The Simpsons

        private Object homer()
        {
            throw new NotImplementedException();
        }

        private Object marge()
        {
            throw new NotImplementedException();
        }

        private Object bart()
        {
            throw new NotImplementedException();
        }

        private Object lisa()
        {
            throw new NotImplementedException();
        }

        private Object maggie()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Homer´s Parents

        private Object abraham()
        {
            throw new NotImplementedException();
        }

        private Object mona()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Marge´s Parents

        private Object clamcy()
        {
            throw new NotImplementedException();
        }

        private Object jackie()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Homer´s Siblings

        private Object herb()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Selma´s Children

        private Object ling()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Marge´s Siblings

        private Object patty()
        {
            throw new NotImplementedException();
        }

        private Object selma()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Clancy's Parents

        private object pepe()
        {
            throw new NotImplementedException();
        }

        private object bambi()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Jackie´s Parents

        private object ferdinand()
        {
            throw new NotImplementedException();
        }

        private object alvarine()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Abraham's Parents

        private object orville()
        {
            throw new NotImplementedException();
        }

        private object yuma()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Mona´s Parents

        private object jay()
        {
            throw new NotImplementedException();
        }

        private object janet()
        {
            throw new NotImplementedException();
        }

        #endregion

        public Object batman()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Stub Methods

        private Object fatherOf(Object aChild)
        {
            throw new NotImplementedException();
        }

        private Object motherOf(Object aChild)
        {
            throw new NotImplementedException();
        }

        private object[] parentsOf(Object aChild)
        {
            throw new NotImplementedException();
        }

        private object[] grandParentsOf(Object aGrandSon)
        {
            throw new NotImplementedException();
        }

        private Object paternalGrandFatherOf(Object aGrandSon)
        {
            throw new NotImplementedException();
        }

        private Object paternalGrandMotherOf(Object aGrandSon)
        {
            throw new NotImplementedException();
        }

        private Object maternalGrandFatherOf(Object aGrandSon)
        {
            throw new NotImplementedException();
        }

        private Object maternalGrandMotherOf(Object aGrandSon)
        {
            throw new NotImplementedException();
        }

        private object[] paternalGrandParentsOf(Object aGrandSon)
        {
            throw new NotImplementedException();
        }

        private object[] maternalGrandParentsOf(Object aGrandSon)
        {
            throw new NotImplementedException();
        }

        private object[] childrenOf(Object aParent)
        {
            throw new NotImplementedException();
        }

        private object[] grandChildrenOf(Object aGrandParent)
        {
            throw new NotImplementedException();
        }

        private object[] greatGrandChildrenOf(Object aGreatGrandParent)
        {
            throw new NotImplementedException();
        }

        private Boolean isUnknown(Object aPerson)
        {
            throw new NotImplementedException();
        }

        private object[] siblingsOf(Object aSibling)
        {
            throw new NotImplementedException();
        }

        private object[] unclesAndAuntsOf(Object aNephew)
        {
            throw new NotImplementedException();
        }

        private object[] unclesOf(Object aNephew)
        {
            throw new NotImplementedException();
        }

        private object[] auntsOf(Object aNephew)
        {
            throw new NotImplementedException();
        }

        private object[] cousinsOf(Object aCousin)
        {
            throw new NotImplementedException();
        }

        private object[] greatGrandParentsOf(Object aGreatGrandSon)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Phase 1

        [TestMethod]
        public void Test01FatherOfShouldReturnTheFatherOfAChild()
        {
            Assert.AreEqual(homer(), fatherOf(bart()));
        }

        [TestMethod]
        public void Test02MotherOfShouldReturnTheMotherOfAChild()
        {
            Assert.AreEqual(marge(), motherOf(bart()));
        }

        [TestMethod]
        public void Test03ParentsShouldOnlyIncludeFatherAndMotherOfAChild()
        {
            var expectedBartParents = new[] { homer(), marge() };

            var bartParents = parentsOf(bart());

            CollectionAssert.AreEquivalent(expectedBartParents, bartParents);
        }


        [TestMethod]
        public void Test04ParentsShouldWorkCorrectlyWithOtherChild()
        {
            var expectedHomerParents = new[] { abraham(), mona() };

            var actualHomerParents = parentsOf(homer());

            CollectionAssert.AreEquivalent(expectedHomerParents, actualHomerParents);
        }

        [TestMethod]
        public void Test05SiblingsShouldReturnTheOtherParentsChildren()
        {
            var expectedBartSiblings = new[] { lisa(), maggie() };
            var expectedLisaSiblings = new[] { bart(), maggie() };
            var expectedMaggieSiblings = new[] { lisa(), bart() };

            var bartSiblings = siblingsOf(bart());
            var lisaSiblings = siblingsOf(lisa());
            var maggieSiblings = siblingsOf(maggie());

            CollectionAssert.AreEquivalent(expectedBartSiblings, bartSiblings);
            CollectionAssert.AreEquivalent(expectedLisaSiblings, lisaSiblings);
            CollectionAssert.AreEquivalent(expectedMaggieSiblings, maggieSiblings);
        }

        [TestMethod]
        public void Test06SiblingsShouldReturnPeopleWithTheSameFatherOrMother()
        {
            var expectedHomerSiblings = new[] { herb() };

            var homerSiblings = siblingsOf(homer());

            CollectionAssert.AreEquivalent(expectedHomerSiblings, homerSiblings);
        }

        [TestMethod]
        public void Test07APersonCanHaveNoSiblings()
        {
            object[] lingSiblings = siblingsOf(ling());

            Assert.AreEqual(0, lingSiblings.Count());
        }

        [TestMethod]
        public void Test08FatherOfInvalidChildShouldRaiseException()
        {
            try
            {
                fatherOf(batman());
                Assert.Fail();
            }
            catch (MemberNotFound memberNotFound)
            {
                Assert.AreEqual(batman(), memberNotFound.subject());
            }
        }

        [TestMethod]
        public void Test09MotherOfInvalidChildShouldRaiseException()
        {
            try
            {
                motherOf(batman());
                Assert.Fail();
            }
            catch (MemberNotFound memberNotFound)
            {
                Assert.AreEqual(batman(), memberNotFound.subject());
            }
        }

        [TestMethod]
        public void Test09aMotherOfAChildWithUnknowMotherShouldBeUnknown()
        {
            Assert.IsTrue(isUnknown(motherOf(herb())));
        }

        #endregion

        #region Phase 2

        [TestMethod]
        public void Test10GrandParentsShouldReturnTheParentsOfTheGrandChildParents()
        {
            var expectedBartGrandParents = new[] { abraham(), mona(), clamcy(), jackie() };

            var bartGrandParents = grandParentsOf(bart());

            CollectionAssert.AreEquivalent(expectedBartGrandParents, bartGrandParents);
        }

        [TestMethod]
        public void Test11GrandParentsOfBrothersAreTheSame()
        {
            var bartGrandParents = grandParentsOf(bart());
            var lisaGrandParents = grandParentsOf(lisa());

            CollectionAssert.AreEquivalent(bartGrandParents, lisaGrandParents);
        }

        [TestMethod]
        public void Test12GrandParentsOfInvalidChildShouldRaiseException()
        {
            try
            {
                grandParentsOf(batman());
                Assert.Fail();
            }
            catch (MemberNotFound memberNotFound)
            {
                Assert.AreEqual(batman(), memberNotFound.subject());
            }
        }

        [TestMethod]
        public void Test13GreatGrandParentsShouldOnlyIncludeTheParentsOfTheChildGrandParents()
        {
            var expectedHomerGrandParents = new[] { orville(), yuma(), jay(), janet() };
            var expectedMargeGrandParents = new[] { pepe(), bambi(), ferdinand(), alvarine() };
            var expectedBartGreatGrandParents = new[] { orville(), yuma(), jay(), janet(),
                                                        pepe(), bambi(), ferdinand(), alvarine() };

            var homerGrandParents = grandParentsOf(homer());
            var margeGrandParents = grandParentsOf(marge());
            var bartGreatGrandParents = greatGrandParentsOf(bart());

            CollectionAssert.AreEquivalent(expectedHomerGrandParents, homerGrandParents);
            CollectionAssert.AreEquivalent(expectedMargeGrandParents, margeGrandParents);
            CollectionAssert.AreEquivalent(expectedBartGreatGrandParents, bartGreatGrandParents);
            CollectionAssert.AreEquivalent(expectedHomerGrandParents, bartGreatGrandParents.Except(margeGrandParents).ToArray());
            CollectionAssert.AreEquivalent(expectedMargeGrandParents, bartGreatGrandParents.Except(homerGrandParents).ToArray());
        }


        [TestMethod]
        public void Test14GreatGrandParentsOfInvalidChildShouldRaiseException()
        {
            try
            {
                greatGrandParentsOf(batman());
                Assert.Fail();
            }
            catch (MemberNotFound memberNotFound)
            {
                Assert.AreEqual(batman(), memberNotFound.subject());
            }
        }

        #endregion

        #region Phase 4

        [TestMethod]
        public void Test15ChildrenShouldReturnTheSonsAndDaugthers()
        {
            var expectedHomerChildren = new[] { bart(), lisa(), maggie() };

            var homerChildren = childrenOf(homer());

            CollectionAssert.AreEquivalent(expectedHomerChildren, homerChildren);
        }

        [TestMethod]
        public void Test16ChildrenOfMarriedPeopleAreTheSame()
        {
            var homerChildren = childrenOf(homer());
            var margeChildren = childrenOf(marge());

            CollectionAssert.AreEquivalent(homerChildren, margeChildren);
        }

        [TestMethod]
        public void Test17ChildrenOfInvalidChildShouldRaiseException()
        {
            try
            {
                childrenOf(batman());
                Assert.Fail();
            }
            catch (MemberNotFound memberNotFound)
            {
                Assert.AreEqual(batman(), memberNotFound.subject());
            }
        }

        [TestMethod]
        public void Test18ChildrenShouldBeEmptyWhenPersonHasNoChildren()
        {
            object[] pattyChildren = childrenOf(patty());

            Assert.AreEqual(0, pattyChildren.Count());
        }

        [TestMethod]
        public void Test19ChildrenCanBeOnePerson()
        {
            var expectedMonaChildren = new[] { homer() };

            var monaChildren = childrenOf(mona());

            CollectionAssert.AreEquivalent(expectedMonaChildren, monaChildren);
        }

        [TestMethod]
        public void Test20GrandChildrenShouldBeTheChildrenOfTheGrandFatherChildren()
        {
            var expectedAbrahamGrandChildren = new[] { bart(), lisa(), maggie() };

            var abrahamGrandChildren = grandChildrenOf(abraham());

            CollectionAssert.AreEquivalent(expectedAbrahamGrandChildren, abrahamGrandChildren);
        }

        [TestMethod]
        public void Test21GrandChildrenShouldIncludeTheChildrenOfAllTheChildren()
        {
            var expectedJackieGrandChildren = new[] { bart(), lisa(), maggie(), ling() };

            var jackieGrandChildren = grandChildrenOf(jackie());

            CollectionAssert.AreEquivalent(expectedJackieGrandChildren, jackieGrandChildren);
        }

        [TestMethod]
        public void Test22GreatGrandChildrenShouldIncludeTheGrandChildrenOfTheChildren()
        {
            var expectedAbrahamFatherGreatGrandChildren = new[] { bart(), lisa(), maggie() };

            var abrahamFatherGreatGrandChildren = greatGrandChildrenOf(fatherOf(abraham()));

            CollectionAssert.AreEquivalent(expectedAbrahamFatherGreatGrandChildren, abrahamFatherGreatGrandChildren);
        }

        [TestMethod]
        public void Test23GreatGrandChildrenShouldIncludeTheGrandChildrenOfAllTheChildren()
        {
            var expectedJackieMotherGreatGrandChildren = new[] { bart(), lisa(), maggie(), ling() };

            var jackieGrandChildren = greatGrandChildrenOf(motherOf(jackie()));

            CollectionAssert.AreEquivalent(expectedJackieMotherGreatGrandChildren, jackieGrandChildren);
        }

        #endregion

        #region Phase 5

        [TestMethod]
        public void Test24UnclesAndAuntsAreParentsSiblings()
        {
            var expectedBartUnclesAndAuts = new[] { herb(), patty(), selma() };

            var bartUnclesAndAunts = unclesAndAuntsOf(bart());

            CollectionAssert.AreEquivalent(expectedBartUnclesAndAuts, bartUnclesAndAunts);
        }


        [TestMethod]
        public void Test25CousingAreUnclesAndAuntsChildren()
        {
            var expectedBartAndLisaCousins = new[] { ling() };
            var expectedLingCousins = new[] { bart(), lisa(), maggie() };

            var bartCousins = cousinsOf(bart());
            var lisaCousins = cousinsOf(lisa());
            var lingCousins = cousinsOf(ling());

            CollectionAssert.AreEquivalent(expectedBartAndLisaCousins, bartCousins);
            CollectionAssert.AreEquivalent(expectedBartAndLisaCousins, lisaCousins);
            CollectionAssert.AreEquivalent(expectedLingCousins, lingCousins);
        }

        #endregion

        #region Phase 6

        [TestMethod]
        public void Test26FatherOfAChildWithUnknownMotherShouldReturnTheKnownFather()
        {
            Assert.AreEqual(abraham(), fatherOf(herb()));
        }

        [TestMethod]
        public void Test28ParentsOfAChildWithUnknowMotherShouldOnlyReturnTheFather()
        {
            var expectedHerbParents = new[] { abraham() };

            var herbParents = parentsOf(herb());

            CollectionAssert.AreEquivalent(expectedHerbParents, herbParents);
        }

        [TestMethod]
        public void Test29ParentsOfAChildWithUnknowFatherShouldOnlyReturnTheMother()
        {
            var expectedLingParents = new[] { selma() };

            var lingParents = parentsOf(ling());

            CollectionAssert.AreEquivalent(expectedLingParents, lingParents);
        }

        [TestMethod]
        public void Test30ChildrenShouldSupportChildrenBornWithDifferentCouple()
        {
            var expectedAbrahamChildren = new[] { homer(), herb() };

            var abrahamChildren = childrenOf(abraham());

            CollectionAssert.AreEquivalent(expectedAbrahamChildren, abrahamChildren);
        }

        [TestMethod, Ignore]
        public void Test31UnclesOnlyIncludesMan()
        {
            object[] bartUncles = unclesOf(bart());
            Assert.AreEqual(1, bartUncles.Count());
            Assert.IsTrue(bartUncles.Contains(herb()));
        }

        [TestMethod, Ignore]
        public void Test32AuntsOnlyIncludeWoman()
        {
            object[] bartAunts = auntsOf(bart());
            Assert.AreEqual(2, bartAunts.Count());
            Assert.IsTrue(bartAunts.Contains(patty()));
            Assert.IsTrue(bartAunts.Contains(selma()));
        }

        [TestMethod]
        public void Test33PaternalGrandFatherIsFatherOfFather()
        {
            Assert.AreEqual(abraham(), paternalGrandFatherOf(bart()));
        }


        [TestMethod]
        public void Test34PaternalGrandMotherIsMotherOfFather()
        {
            Assert.AreEqual(mona(), paternalGrandMotherOf(bart()));
        }

        [TestMethod]
        public void Test35MaternalGrandFatherIsFatherOfMother()
        {
            Assert.AreEqual(clamcy(), maternalGrandFatherOf(bart()));
        }


        [TestMethod]
        public void Test36MaternalGrandMotherIsMotherOfMother()
        {
            Assert.AreEqual(jackie(), maternalGrandMotherOf(bart()));
        }

        [TestMethod]
        public void Test37PaternalGrandParentsShouldOnlyIncludeTheParentsOfTheChildFather()
        {
            var expectedBartPaternalGrandParents = new[] { abraham(), mona() };

            var bartPaternalGrandParents = paternalGrandParentsOf(bart());

            CollectionAssert.AreEquivalent(expectedBartPaternalGrandParents, bartPaternalGrandParents);
        }


        [TestMethod]
        public void Test38MaternalGrandParentsShouldOnlyIncludeTheParentsOfTheChildMother()
        {
            var expectedBartMaternalGrandParents = new[] { clamcy(), jackie() };

            var bartMaternalGrandParents = maternalGrandParentsOf(bart());

            CollectionAssert.AreEquivalent(expectedBartMaternalGrandParents, bartMaternalGrandParents);
        }

        #endregion
    }
}