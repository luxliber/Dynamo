using System;
using NUnit.Framework;
using ProtoTestFx;
namespace ProtoTest.DebugTests
{
    [TestFixture]
    public class RunEqualityTests
    {

        [Test]
        [Category("Debugger")]
        public void DebugEQTestStepInVsStepOver_IDE618_01()
        {
            String src =
                @" 
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestStepInVsStepOver_IDE618_02()
        {
            String src =
                @" 
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestStepInVsStepOver_IDE618_03()
        {
            String src =
                @" 
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestStepInVsStepOver_IDE618_04()
        {
            String src =
                @" 
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestStepInVsStepOver_IDE618_05()
        {
            String src =
                @" 
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestStepInVsStepOver_IDE618_06()
        {
            String src =
                @" 
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestStepInVsStepOver_IDE618_07()
        {
            String src =
                @" 
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestStepInVsStepOver_IDE481_01()
        {
            String src =
                @" 
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestArrayAssignUserType()
        {
            String src =
                @" class B
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestEqualityR1()
        {
            String src =
                @" a = 4;";
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestEqualityImpR1()
        {
            String src =
                @" a = 0; [Imperative] {
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        [Category("Debugger")]
        public void DebugEQTestEquality0001()
        {
            String src =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(src);
        }

        [Test]
        public void DebugEQBIM01_SomeNulls()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQBIM02_CountTrue()
        {
            String code =
                @"a = {true,true,true,false,{true,false},true,{false,false,{true,{false},true,true,false}}};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQBIM03_CountFalse()
        {
            String code =
                @"a = {true,true,true,false,{true,false},true,{false,false,{true,{false},true,true,false}}};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "AllFalse() & AllTrue()"
        public void DebugEQBIM04_AllFalse_AllTrue()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "IsHomogeneous()"
        public void DebugEQBIM05_IsHomogeneous()
        {
            String code =
                @"a = {1,2,3,4,5};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Sum() & Average()"
        public void DebugEQBIM06_SumAverage()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "SomeTrue() & SomeFalse()"
        public void DebugEQBIM07_SomeTrue_SomeFalse()
        {
            String code =
                @"a = {true,true,true,{false,false,{true, true,{false},true,true,false}}};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Remove() & RemoveDuplicate()"
        public void DebugEQBIM08_Remove_RemoveDuplicate()
        {
            String code =
                @"a = {null,20,30,null,20,15,true,true,5,false};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "RemoveNulls()"
        public void DebugEQBIM09_RemoveNulls()
        {
            String code =
                @"a = {1,{6,null,7,{null,null}},7,null,2};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "RemoveIfNot()"
        public void DebugEQBIM10_RemoveIfNot()
        {
            String code =
                @"a = {""This is "",""a very complex "",""array"",1,2.0,3,false,4.0,5,6.0,true,{2,3.1415926},null,false,'c'};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Reverse()"
        public void DebugEQBIM11_Reverse()
        {
            String code =
                @"a = {1,{{1},{3.1415}},null,1.0,12.3};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Contains()"
        public void DebugEQBIM12_Contains()
        {
            String code =
                @"a = {1,{{1},{3.1415}},null,1.0,12.3};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "IndexOf()"
        public void DebugEQBIM13_IndexOf()
        {
            String code =
                @"a = {1,{{1},{3.1415}},null,1.0,12,3};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Sort()"
        public void DebugEQBIM14_Sort()
        {
            String code =
                @"a = {1,3,5,7,9,8,6,4,2,0};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "SortIndexByValue()"
        public void DebugEQBIM15_SortIndexByValue()
        {
            String code =
                @"a = {1,3,5,7,9,8,6,4,2,0};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Insert()"
        public void DebugEQBIM16_Insert()
        {
            String code =
                @"a = {false,2,3.1415926,null,{false}};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "SetDifference(), SetUnion() & SetIntersection()"
        public void DebugEQBIM17_SetDifference_SetUnion_SetIntersection()
        {
            String code =
                @"a = {false,15,6.0,15,false,null,15.0};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Reorder"
        public void DebugEQBIM18_Reorder()
        {
            String code =
                @"a = {1,4,3,8.0,2.0,0};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "IsUniformDepth"
        public void DebugEQBIM19_IsUniformDepth()
        {
            String code =
                @"a = {};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "NormailizeDepth"
        public void DebugEQBIM20_NormalizeDepth()
        {
            String code =
                @"a = {{1,{2,3,4,{5}}}};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Map & MapTo"
        public void DebugEQBIM21_Map_MapTo()
        {
            String code =
                @"a = Map(80.0, 120.0, 100.0);
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Transpose"
        public void DebugEQBIM22_Transpose()
        {
            String code =
                @"a = {{1,2,3},{1,2},{1,2,3,4,5,6,7}};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "LoadCSV"
        public void DebugEQBIM23_LoadCSV()
        {
            String code =
                @"a = ""CSVTestCase/test1.csv"";
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Count"
        public void DebugEQBIM24_Count()
        {
            String code =
                @"a = {1, 2, 3, 4};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Rank"
        public void DebugEQBIM25_Rank()
        {
            String code =
                @"a = { { 1 }, 2, 3, 4 };
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "Flatten"
        public void DebugEQBIM26_Flatten()
        {
            String code =
                @"a = {1, 2, 3, 4};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        //Test "CountTrue/CountFalse/Average/Sum/RemoveDuplicate"
        public void DebugEQBIM27_Conversion_Resolution_Cases()
        {
            String code =
                @"a = {null,20,30,null,{10,0},true,{false,0,{true,{false},5,2,false}}};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethometicalFunction()
        {
            String code =
                @"import(""math.dll"");
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTrigonometricFunction()
        {
            String code =
                @"import(""math.dll"");
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInheritanceTest01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInheritanceTest02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInheritanceTest03()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInheritanceTest04()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQSimpleCtorResolution01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQSimpleCtorResolution02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQSimpleCtorResolution03()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQSimpleCtorResolution04()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverload1()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverload2()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverload3()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverload4()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodResolutionOverInheritance()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverlaodAndArrayInput1()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverlaodAndArrayInput2()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverlaodAndArrayInput3()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverlaodAndArrayInput4()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverlaodAndArrayInput4Min()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Method Resolution")]
        public void DebugEQTestStaticDispatchOnArray()
        {
            //Recorded as defect: DNL-1467146
            string code =
                @"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Method Resolution")]
        [Category("Escalate")]
        public void DebugEQTestStaticDispatchOnEmptyArray()
        {
            string code =
                @"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverlaodAndArrayInput5()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodOverlaodAndArrayInput6()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodWithArrayInput1()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodWithArrayInput2()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Method Resolution")]
        public void DebugEQTestMethodWithArrayInputOverload()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Method Resolution")]
        public void DebugEQTestMethodWithArrayInputOverloadDirectType()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestMethodWithOverrides()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestOverridenMethod()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestAssignment01_002()
        {
            String code =
                @"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestNull01_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestNull02_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestFunctions01()
        {
            String code =
                @"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestFunctions02()
        {
            String code =
                @"        
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestFunctionsOverload01()
        {
            String code =
                @"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestFunctionsOverload02()
        {
            String code =
                @"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestFunctionsOverload03()
        {
            String code =
                @"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicDispatch01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClasses01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClasses02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClasses03()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClasses04()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClasses05()
        {
            String code =
                @"  
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClasses06()
        {
            String code =
                @"  
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClasses07()
        {
            String code =
                @"  
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction03()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction04()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction05()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction06()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction07()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction08()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction09()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction10()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction11()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction12()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction13()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("JunToFix")]
        public void DebugEQTestClassFunction14()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction15()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction16()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestClassFunction17()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestStaticProperty01()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestStaticProperty02()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Method Resolution")]
        public void DebugEQTestStaticFunction01()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestStaticMethodResolution()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArray001()
        {
            String code =
                @"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArray002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArray003()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestIndexingIntoArray01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestIndexingIntoArray02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArrayOverIndexing01_002()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray001_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray003()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray004()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray005()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray006()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray007()
        {
            String code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray008()
        {
            String code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray009()
        {
            String code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray010()
        {
            String code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray011()
        {
            String code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray012()
        {
            String code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray013()
        {
            String code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray014()
        {
            String code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray015()
        {
            String code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray016()
        {
            String code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArrayIndexReplication01()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArrayIndexReplication02()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypeArrayAssign4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypeArrayAssign5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypeArrayAssign6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNestedBlocks001_002()
        {
            String code =
                @"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQBitwiseOp001_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQBitwiseOp002_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQBitwiseOp003_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQBitwiseOp004_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp001_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp002_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp003_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDoubleOp_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRangeExpr001_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRangeExpr002_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRangeExpr003_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRangeExpr004_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRangeExpr005_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQFunctionWithinConstr001()
        {
            String code =
                @"                        
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInlineCondition001_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInlineCondition002_002()
        {
            String code =
                @"	
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInlineCondition003_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInlineCondition004()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQPrePostFix001_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQPrePostFix002_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQPrePostFix003_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQModulo001_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQModulo002_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNegativeIndexOnCollection001_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNegativeIndexOnCollection002_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNegativeIndexOnCollection003_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQPopListWithDimension_002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestUpdate01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestUpdate03()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArrayUpdateRedefinition01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArrayUpdateRedefinition02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArrayUpdate01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestFunctionUpdate01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestNoUpdate01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestPropertyUpdate01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        // Comment Jun: Investigate how replicating setters have affected this update

        [Test]
        public void DebugEQTestPropertyUpdate02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestPropertyUpdate03()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestPropertyUpdate04()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestPropertyUpdate05()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestPropertyUpdate06()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestPropertyModificationInMethodUpdate01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestPropertyModificationInMethodUpdate02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestXLangUpdate01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestXLangUpdate02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestXLangUpdate03()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestGCRefCount()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestGCFFI001()
        {
            String code =
                @"
            code = string.Format("{0}\n{1}", "import(\"ProtoGeometry.dll\");", code);
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestGCRefCount002()
        {
            String code =
                @"
            code = string.Format("{0}\n{1}", "import(\"ProtoGeometry.dll\");", code);
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestGlobalVariable()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        [Category("Feature")]
        public void DebugEQTestTryCatch001_002()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypeArrayAssign()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypeArrayAssign2()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypeArrayAssign3()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypedAssignment01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypedAssignment02()
        {
            string code =
                @" t1:int = 1;
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypedAssignment03()
        {
            string code =
                @" 
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypedAssignment04()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypedAssignment05()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestTypedAssignment06()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Escalate")]
        [Category("ToFixJun")]
        public void DebugEQTestPropAssignWithReplication()
        {
            //Assert.Fail("DNL-1467241 Sprint25: rev 3420 : Property assignments using replication is not working");
            string code =
                @"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestPropAssignWithReplication02()
        {
            string code =
                @"class A 
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRedefineWithFunctions01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("ToFixYuKe")]
        public void DebugEQRedefineWithFunctions02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRedefineWithFunctions03()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        //TestCase from Mark//

        [Test]
        public void DebugEQRedefineWithFunctions04()
        {
            String code =
                @"def f1(i : int, k : int)
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRedefineWithFunctions05()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRedefineWithExpressionLists01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRedefineWithExpressionLists02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        //Mark TestCases//

        [Test]
        [Category("ToFixJun")]
        public void DebugEQRedefineWithExpressionLists03()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRedefineWithExpressionLists04()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount_BaseCase01()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount01_NoFunctionCall()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount02_FunctionNonArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount03_FunctionReplication()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount04_FunctionArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount05_StaticFunctionNonArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount06_StaticFunctionReplication()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount07_StaticFunctionArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount08_MemFunctionNonArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount09_MemFunctionReplication()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount10_MemFunctionArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount11_ReplicationNonArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount12_ReplicationReplication()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount13_ReplicationArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount14_GlobalFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount15_GlobalFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount16_GlobalFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount17_StaticFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount18_StaticFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount19_StaticFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount20_MemberFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount21_MemberFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount22_MemberFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount23_MemberFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount24_MemberFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount25_MemberFunctionTwoArguments()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount26_GlobalFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount27_GlobalFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount28_GlobalFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount29_MemberFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount30_MemberFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount31_MemberFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount32_StaticFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount33_StaticFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount34_StaticFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount35_StaticFunctionReturnObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount36_StaticFunctionReturnObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount37_MemberFunctionReturnObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount38_MemberFunctionReturnObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount39_GlobalFunctionReturnObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount40_GlobalFunctionReturnObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount41_MemberFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount42_MemberFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount43_MemberFunctionReturnArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount44_MemberFunctionReturnObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount45_MemberFunctionReturnObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount46_GlobalFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount47_GlobalFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount48_GlobalFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount49_MemberFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount50_MemberFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount51_MemberFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount52_StaticFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount53_StaticFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount54_StaticFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount55_StaticFunctionReturnNewObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount56_StaticFunctionReturnNewObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount57_MemberFunctionReturnNewObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount58_MemberFunctionReturnNewObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount59_GlobalFunctionReturnNewObject()
        {
            string code =
                @"

            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount60_GlobalFunctionReturnNewObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount61_MemberFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount62_MemberFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount63_MemberFunctionReturnNewArray()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount64_MemberFunctionReturnNewObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount65_MemberFunctionReturnNewObject()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount66_DID1467277()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("DebuggerReferenceCount")]
        public void DebugEQTestReferenceCount67_DID1467277_02()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQArrayConvTest()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRedefConvTest()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRetArrayTest()
        {
            //DNL-1467221 Sprint 26 - Rev 3345 type conversion to array as return type does not get converted
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("ToFixLuke")]
        public void DebugEQRetArrayTest2()
        {
            //DNL-1467221 Sprint 26 - Rev 3345 type conversion to array as return type does not get converted
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQStatementArrayTest()
        {
            //DNL-1467221 Sprint 26 - Rev 3345 type conversion to array as return type does not get converted
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQStatementArrayTest2()
        {
            //DNL-1467221 Sprint 26 - Rev 3345 type conversion to array as return type does not get converted
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRep1()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRep2()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRep3()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRep4()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRep5()
        {
            //Assert.Fail("DNL-1467183 Sprint24: rev 3163 : replication on nested array is outputting extra brackets in some cases");
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQMinimalStringTest()
        {
            String code =
                @"a = ""Callsite is an angry bird"";
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQSimpleUpCast()
        {
            String code =
                @"def foo(x:int[])
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTypedAssign()
        {
            String code =
                @"x : int = 2.3;";
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestVarUpcast()
        {
            string code =
                @"x : var[] = 3;";
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestVarDispatch()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestVarDispatchOnArrayStructure()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestVarDispatchOnArrayStructure2()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestVarReturnOnArrayStructure()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArbitraryRankArr()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestAssignFailDueToRank()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestAssignment01()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestAssignment02()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestNull01()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestNull02()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQFibonacci_recusion()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestFunction01()
        {
            String code =
                @"
                ;
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestFunction02()
        {
            string code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestFunction03()
        {
            string code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQIfStatement01()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQIfStatement02()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQIfStatement03()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQIfStatement04()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQIfStatement05()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQIfStatement06()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQIfStatement07()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQIfStatement08()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQIfStatement09()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQIfStatement10()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNestedBlocks001()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNegativeFloat001()
        {
            String code =
                @"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQForLoop01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQForLoop02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQForLoop03()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQForLoop04()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQForLoop05()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQBitwiseOp001()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQBitwiseOp002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQBitwiseOp003()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQBitwiseOp004()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp001()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp003()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp004()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp005()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp006()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp007()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLogicalOp008()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDoubleOp()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRangeExpr001()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRangeExpr002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRangeExpr003()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRangeExpr004()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRangeExpr005()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQWhileStatement01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQWhileStatement02()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRecurringDecimal01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQFactorial01()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQToleranceTest()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInlineCondition001()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInlineCondition002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQInlineCondition003()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQPrePostFix001()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQPrePostFix002()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]
        public void DebugEQPrePostFix003()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQModulo001()
        {
            String code =
                @"  [Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQModulo002()
        {
            String code =
                @"   [Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNegativeIndexOnCollection001()
        {
            String code =
                @"  [Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNegativeIndexOnCollection002()
        {
            String code =
                @"  [Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNegativeIndexOnCollection003()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQPopListWithDimension()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestArrayOverIndexing01()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTestDynamicArray001()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQTestTryCatch001()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQTestTryCatch002()
        {
            string code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQEmbeddedTest001()
        {
            String code =
@"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQEmbeddedTest002()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQEmbeddedTest003()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQEmbeddedTest006()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLanguageBlockReturn01()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLanguageBlockReturn02()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNestedBlockInFunction01()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQNestedBlockInFunction02()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQAccessGlobalVariableInsideFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_FunctionPointer_Update()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_FunctionPointerArray()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_FunctionPointerAsReturnValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_FunctionPointerAsReturnValue2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_FunctionPointerTypeConversion()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_NestedFunctionPointer()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_FunctionPointerDefaultParameter()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT28_FunctionPointerInInlineCond()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void T29_FunctionPointerInInlineCond()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_TypeConversion()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_UsedAsMemberVariable()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQSimpleOp()
        {
            String code =
@"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQArraySimpleOp()
        {
            String code =
@"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQArraySimpleCall01()
        {
            String code =
@"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQArraySimpleCall02()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void ArraySimpleCall03()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQArraySimpleCall04()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQTestSimpleCallAssociative()
        {
            String code =
@"def fun : double() { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void TestSimpleCallImperative()
        {
            String code =
@"def fun : double() { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void TestSimpleCallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQTest1D1CellArrayCallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQTest1DDeepNestCellArrayCallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQTest1D2DeepNestCellArrayCallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Test1DnCellArrayCallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQTest2DnSquareCellArrayCallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQTest2DnJaggedCellArrayCallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Test1D1DSimpleCallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double, arg2:double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Test1D1D2CallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double, arg2:double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQTest1D1DCellArrayCallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double, arg2:double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQTest2D2CellArrayCallWithArgAssociative()
        {
            String code =
@"def fun : double(arg: double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQTestIncompatibleTypes()
        {
            String code =
@"def fun : double(arg: int) { return = 4; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQTestOverloadDispatchWithTypeConversion()
        {
            String code =
@"class TestDefect
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT09_Defect_1456568_Replication_On_Operators()
        {
            String code =
@"xdata = {1, 2};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT09_Defect_1456568_Replication_On_Operators_2()
        {
            String code =
@"xdata = {1, 2};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT09_Defect_1456568_Replication_On_Operators_3()
        {
            String code =
@"xdata = {1, 2, 5, 7};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT09_Defect_1456568_Replication_On_Operators_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT09_Defect_1456568_Replication_On_Operators_5()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT09_Defect_1456568_Replication_On_Operators_6()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT09_Defect_1456568_Replication_On_Operators_7()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT57_Defect_1467004_Replication_With_Method_Overload()
        {
            String code =
                            @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT57_Defect_1467004_Replication_With_Method_Overload_2()
        {
            String code =
                            @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT57_Defect_1467004_Replication_With_Method_Overload_3()
        {
            String code =
                            @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT57_Defect_1467004_Replication_With_Method_Overload_4()
        {
            String code =
                            @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT57_Defect_1467004_Replication_With_Method_Overload_5()
        {
            String code =
                            @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT57_Defect_1467004_Replication_With_Method_Overload_6()
        {
            String code =
                            @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT57_Defect_1467004_Replication_With_Method_Overload_7()
        {
            String code =
                            @"  def foo(val : int[])
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT58_Defect_1456115_Replication_Over_Collections()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT58_Defect_1456115_Replication_Over_Collections_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT58_Defect_1456115_Replication_Over_Collections_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT58_Defect_1456115_Replication_Over_Collections_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT58_Defect_1456115_Replication_Over_Collections_5()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT58_Defect_1456115_Replication_Over_Collections_6()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Update")]
        public void T58_Defect_1456115_Replication_Over_Collections_7()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT59_Defect_1463351_Replication_Over_Unary_Operators()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT59_Defect_1463351_Replication_Over_Unary_Operators_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT59_Defect_1463351_Replication_Over_Unary_Operators_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT59_Defect_1463351_Replication_Over_Unary_Operators_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT60_Defect_1455247_Replication_Over_Class_Instances()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT60_Defect_1455247_Replication_Over_Class_Instances_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT60_Defect_1455247_Replication_Over_Class_Instances_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT60_Defect_1455247_Replication_Over_Class_Instances_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT60_Defect_1455247_Replication_Over_Class_Instances_5()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void DebugEQT60_Defect_1455247_Replication_Over_Class_Instances_6()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT61_Defect_1463338_Replication_CallSite_Assertion()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT62_Defect_1467075_replication_on_nested_array()
        {
            String code =
@"def fun : double(arg: double) { return = 4.0; }
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        [Category("Replication")]
        public void DebugEQT63_Defect_1467177_replication_in_imperative()
        {
            // need to move this to post R1 project
            String code =
@"[Imperative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT64_Defect_1456105_replication_on_function_with_no_arg_type()
        {
            String code =
@"[Associative]
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT64_Defect_1456105_replication_on_function_with_no_arg_type_2()
        {
            String code =
@"def foo2 : double (arr : double)
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT64_Defect_1456105_replication_on_function_with_no_arg_type_3()
        {
            String code =
@"def foo2  (x )
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT66_Defect_1467125_Replication_Method()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT66_Defect_1467125_Replication_Method_2()
        {
            String code =
                    @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTest()
        {
            String code =
                    @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQArray_Ranks_Match_argumentdefinition_1467190()
        {
            String code =
            @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT66_Defect_1467198_Inline_Condition_With_Jagged_Array()
        {
            String code =
@"a = { 1, 2};
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT67_Defect_1460965_Replication_On_Dot_Operator()
        {
            String code =
@"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT67_Defect_1460965_Replication_On_Dot_Operator_2()
        {
            String code =
@"class Point
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT67_Defect_1460965_Replication_On_Dot_Operator_3()
        {
            String code =
@"class MyPoint 
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT67_Defect_1460965_Replication_On_Dot_Operator_4()
        {
            String code =
@"class MyPoint 
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT67_Defect_1460965_Replication_On_Dot_Operator_5()
        {
            String code =
@"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT67_Defect_1460965_Replication_On_Dot_Operator_6()
        {
            String code =
@"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT67_Defect_1460965_Replication_On_Dot_Operator_8()
        {
            String code =
@"class A
            string error = "1467264 - Sprint25: rev 3548 : over indexing should yield null value";
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT67_Defect_1460965_Replication_On_Dot_Operator_10()
        {
            String code =
@"class A
            string error = "";// "1467266 - Sprint25: rev 3549 : Accessing array members is not giving the expected result";
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT68_Defect_1460965_Replication_On_Dot_Operator_7()
        {
            String code =
@"class A 
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQArrayConvertTest()
        {
            String code =
@"def foo : int (i : double)
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT68_Defect_1460965_Replication_On_Dot_Operator_8()
        {
            String code =
@"class A 
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT68_Defect_1460965_Replication_On_Dot_Operator_9()
        {
            String code =
@"class A 
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT69_Replication_Across_Language_Blocks()
        {
            String code =
@"def foo ( p : double)
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT70_Defect_1467266()
        {
            String code =
@"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void T71_Defect_1467209()
        {
            String code =
@"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT71_Defect_1467209_2()
        {
            String code =
@"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT71_Defect_1467209_3()
        {
            String code =
@"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT71_Defect_1467209_4()
        {
            String code =
@"class A
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT72_Defect_1467169()
        {
            String code =
@"a = { 1, 2 } ;
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT72_Defect_1467169_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT72_Defect_1467169_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT72_Defect_1467169_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT72_Defect_1467169_5()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT72_Defect_1467169_6()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT72_Defect_1467169_7()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT73_Defect_1467069()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        [Category("Replication")]
        public void DebugEQT73_Defect_1467069_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT73_Defect_1467069_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT73_Defect_1467069_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        [Category("Replication")]
        public void DebugEQT74_Defect_1463465()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT74_Defect_1463465_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT75_Defect_1467282()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT75_Defect_1467282_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void T75_Defect_1467282_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT75_Defect_1467282_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT75_Defect_1467282_5()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT76_Defect_1467254()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT76_Defect_1467254_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT77_Defect_1467081()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT77_Defect_1467081_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT77_Defect_1467081_3()
        {
            String code =
                @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT78_Defect_1467125()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT78_Defect_1467125_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT78_Defect_1467125_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT78_Defect_1467125_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT78_Defect_1467125_5()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT78_Defect_1467125_6()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT79_Defect_1467096()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT79_Defect_1467096_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT79_Defect_1467096_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT79_Defect_1467096_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT80_Defect_1467297()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT80_Defect_1467297_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT80_Defect_1467297_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT80_Defect_1467297_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT80_Defect_1467297_5()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT80_Defect_1467297_6()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT80_Defect_1467297_7()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT80_Defect_1467297_8()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT81_Defect_1467298()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT81_Defect_1467299()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT81_Defect_1467299_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT81_Defect_1467299_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT81_Defect_1467299_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT81_Defect_1467299_5()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT81_Defect_1467299_6()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT81_Defect_1467299_7()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT82_Defect_1467244()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT82_Defect_1467244_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT82_Defect_1467244_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT83_Defect_1467253()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT84_Defect_1467313()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT85_Defect_1467076()
        {
            String code =
                    @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT85_Defect_1467076_a()
        {
            String code =
                    @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT85_Defect_1467076_2()
        {
            String code =
                    @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT85_Defect_1467076_2b()
        {
            String code =
                    @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT86_Defect_1467285()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT86_Defect_1467285_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT86_Defect_1467285_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT86_Defect_1467285_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT87_Defect_1467284()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT88_Defect_1467296()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT88_Defect_1467296_2()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT88_Defect_1467296_3()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT88_Defect_1467296_4()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT89_Defect_1467328()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Category("Replication")]
        public void DebugEQT90_Defect_1467285()
        {
            String code =
@"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQBaseImportAssociative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQBaseImportImperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQBaseImportWithVariableClassInstance()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQCollection_Assignment_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQCollection_Assignment_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQCollection_Assignment_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQCollection_Assignment_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQCollection_Assignment_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQComments_1467117()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQComments_1467117_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQComments_Basic()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQComments_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQComments_Nested()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQCompilationErrorExpected()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDNITest()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDefect_Geo_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDemoSupportFiles()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDemo_SinWave_WithoutGeometry()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDisposeVerify()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDynamicReferenceResolving_Complex_Case()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDynamicReference_FunctionCall()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDynamicReference_FunctionCall_With_Default_Arg()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQDynamicReference_Variable()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQFibonacci()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQGarbageCollection_1467148()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQGeometryLibForLanguageTesting__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQGeometryLibForLanguageTesting__3_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQGeometryLibForLanguageTesting()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQImportTest001()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLineTest()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLineTest1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLineTest2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQLineTest3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1452951()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454511()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454692()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454692_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454918_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454918_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454918_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454918_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454918_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454918_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454926()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454966()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454966_10()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454966_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454966_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454966_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454966_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454966_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454966_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454966_8()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454966_9()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1454980()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455158()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455276()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455283()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455283_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455291()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455568()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455584()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455618()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455621()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455643()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455729()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455738()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1455935()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456611()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456611_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456611_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456611_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456611_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456611_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456611_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456611_8()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456611_9()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456713()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456758()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456895()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456895_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1456895_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1457023()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1457023_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1457023_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1457023_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1457023_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1457179()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1457862()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1457885()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1457903()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458187()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458187_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458187_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458475()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458475_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458561()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458567()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458785()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458785_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458785_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458785_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458915()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458915_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458915_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458916()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458918_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1458918_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459171_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459171_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459175()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459175_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459372()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459512()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459584()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459584_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459584_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459584_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459584_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459584_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459584_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459584_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459584_8()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459630()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459762()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459900()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1459900_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1462308()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1467091()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1467094_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1467094_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1467104()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1467107()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1467117()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQRegress_1467127()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQSquareRoot()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00001_Language_001_Variable_Expression_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00002_Language_001a_array_test_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00003_Language_001b_replication_expressions()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00004_Geometry_002_line_by_points_replication_simple()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00005_Geometry_002_line_by_points_replication_simple_correction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00006_Geometry_003_line_by_points_replication_array()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00007_Geometry_004_circle_all_combinations()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00008_Geometry_005_circle_adjacent_pairs_externalised()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00009_Geometry_006_circle_all_unique_combinations()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00010_Geometry_007_specialPoint_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00011_Geometry_008_trim_then_tube_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00012_Geometry_008a_alternative_method_invocations_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00013_Geometry_009_nested_user_defined_feature_2b()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00014_Geometry_010_nested_user_defined_feature_rand_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00015_Geometry_011_nested_user_defined_feature_with_partial_class_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00016_Geometry_012_centroid_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT00017_Geometry_015_Happy_Xmas_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_Associative_Class_Property_Int()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_Associative_Function_DeclareAfterAssignment()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_Associative_Function_Simple()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_BasicImport_CurrentDirectory()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_FFI_MathLibrary_Sqrt_Trigonomatry()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_Inline_Using_Function_Call__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_Inline_Using_Function_Call()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_LanguageBlockScope_AssociativeNestedAssociative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_Language_specifier_invalid_1467065_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_Language_specifier_invalid_1467065_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_SampleTest()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_Simple_Update()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_SomeNulls_IfElse_01()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_SomeNulls_IfElse_02()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_implicit_programming_Robert()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT001_implicit_programming_Robert_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT002_Associative_Class_Property_Double()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT002_Associative_Function_SinglelineFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT002_BasicImport_AbsoluteDirectory()
        {


            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT002_FFI_Matrix_Simple()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT002_Inline_Using_Math_Lib_Functions__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT002_Inline_Using_Math_Lib_Functions()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT002_LanguageBlockScope_ImperativeNestedImperaive()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT002_SomeNulls_ForLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT002_Update_Collection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT002_limits_to_replication_1_Robert()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT003_Associative_Class_Property_Bool()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT003_Associative_Function_MultilineFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT003_BasicImport_ParentPath()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT003_FFI_Tuple4_XYZH_Simple()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT003_Inline_Using_Collection__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT003_Inline_Using_Collection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT003_LanguageBlockScope_ImperativeNestedAssociative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT003_SomeNulls_WhileLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT003_Update_In_Function_Call()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT003_modifying_members_of_a_collection_abstract_1_Robert()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT004_Associative_Class_Property_DefaultInitialization()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT004_Associative_Function_SpecifyReturnType()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT004_BasicImport_CurrentDirectoryWithDotAndSlash()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT004_FFI_Tuple4_XYZ_Simple_WithGetMethods()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT004_Inline_Inside_Class_Constructor_and_replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT004_LanguageBlockScope_AssociativeNestedImperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT004_SomeNulls_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT004_Update_In_Function_Call_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT004_simple_order_1_Robert()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT005_Associative_Class_Property_Get_InternalClassFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT005_Associative_Function_SpecifyArgumentType()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT005_BasicImport_RelativePath()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT005_FFI_Tuple4_ByCoordinate3_Simple()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT005_Inline_Using_2_Collections_In_Condition__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT005_Inline_Using_2_Collections_In_Condition()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT005_LanguageBlockScope_DeepNested_IAI()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT005_SomeNulls_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT005_Update_In_collection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT005_modifiers_with_right_assignments_Robert()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT006_Associative_Class_Property_UseInsideInternalClassFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT006_Associative_Function_PassingNullAsArgument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT006_BasicImport_TestFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT006_FFI_Tuple4_ByCoordinate4_Simple()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT006_Inline_Using_Different_Sized_1_Dim_Collections__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT006_Inline_Using_Different_Sized_1_Dim_Collections()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT006_LanguageBlockScope_DeepNested_AIA()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT006_SomeNulls_Inline()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT006_Update_In_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT006_grouped_1_Robert()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT007_Associative_Class_Property_CallFromFunctionOutsideClass()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT007_Associative_Function_NestedFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT007_BasicImport_TestClassConstructorAndProperties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT007_FFI_Tuple4_Multiply_Simple()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT007_Inline_Using_Collections_And_Replication_CollectionFunctionCall__2_()
        {
            string code = @"
            // defect : DNL-1467619 Regression : Replication + InlineCondition yields different output in release and debug mode
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT007_Inline_Using_Collections_And_Replication_CollectionFunctionCall()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT007_LanguageBlockScope_AssociativeParallelImperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT007_SomeNulls_RangeExpression()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT007_Update_In_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT007_surface_trimmed_with_modifier_and_named_states_Robert()
        {
            string code = @"
            //Assert.Fail("");
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT008_Associative_Class_Property_CallFromAnotherExternalClass()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT008_Associative_Function_DeclareVariableBeforeFunctionDeclaration()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT008_BasicImport_TestClassConstructorAndProperties_UserDefinedClass()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT008_FFI_Transform_ByDate_Simple()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT008_Inline_Returing_Different_Ranks__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT008_Inline_Returing_Different_Ranks()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT008_LanguageBlockScope_ImperativeParallelAssociative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT008_SomeNulls_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT008_Update_Of_Variables()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT008_long_hand_surface_trim_Robert()
        {
            string code = @"
            //Assert.Fail("");
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT009_Associative_Class_Property_AssignInDifferentNamedConstructors()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT009_Associative_Function_DeclareVariableInsideFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT009_BasicImport_TestClassInstanceMethod()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT009_FFI_Transform_ByTuples_Simple()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT009_Inline_Using_Function_Call_And_Collection_And_Replication__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT009_Inline_Using_Function_Call_And_Collection_And_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT009_LanguageBlockScope_UpdateVariableInNestedLanguageBlock_IA()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT009_SomeNulls_DynamicArray()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT009_Update_Of_Undefined_Variables()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT009_modifier_test_1_Robert()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_Associative_Class_Constructor_Overloads()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_Associative_Function_PassAndReturnBooleanValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_BaseImportWithVariableClassInstance_top()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_Defect_1456751_execution_on_both_true_and_false_path_issue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_Defect_1456751_replication_issue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_FFI_Transform_ApplyTransform()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_Inline_Using_Literal_Values()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_LanguageBlockScope_UpdateVariableInNestedLanguageBlock_AI()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_SomeNulls_AssociativeImperative_01()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQT010_SomeNulls_AssociativeImperative_02()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_SomeNulls_AssociativeImperative_03()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_Update_Of_Singleton_To_Collection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT010_imperative_if_inside_for_loop_1_Robert()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT011_Associative_Class_Property_ExtendedClass()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT011_Associative_Function_FunctionWithoutArgument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT011_Cyclic_Dependency_From_Geometry()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT011_Defect_1467281_conditionals()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT011_Defect_ModifierStack()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT011_FFI_Transform_NativeMultiply()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT011_Inline_Using_Variables()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT011_LanguageBlockScope_AssociativeParallelAssociative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT011_SomeNulls_ModifierStack()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT011_Update_Of_Variable_To_Null()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT012_Associative_Class_Property_Var()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT012_Associative_Function_MultipleFunctions()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT012_BaseImportImperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT012_CountTrue_IfElse()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT012_FFI_Transform_NativePreMultiply()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT012_Inline_Using_Fun_Calls()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT012_LanguageBlockScope_ImperativeParallelImperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT012_Update_Of_Variables_To_Bool()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT012_property_test_on_collections_2_Robert()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT013_Associative_Class_Property_GetFromAnotherConstructorInSameClass()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT013_Associative_Function_FunctionWithSameName_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT013_BaseImportImperative_Bottom()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT013_CountTrue_ForLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT013_FFI_Transform_TransformVector()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT013_Inline_Using_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT013_LanguageBlockScope_MultipleParallelLanguageBlocks_AIA()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT013_Update_Of_Variables_To_User_Defined_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT013_nested_programming_blocks_1_Robert()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT014_Associative_Class_Property_GetUsingMultipleReferencingWithSameName()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT014_Associative_Function_DuplicateVariableAndFunctionName_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT014_BasicImport_BeforeImperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT014_CountTrue_WhileLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT014_FFI_Transform_TransformPoint()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT014_Inline_Using_Collections()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT014_LanguageBlockScope_MultipleParallelLanguageBlocks_IAI()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT014_Update_Of_Class_Properties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT015_Associative_Class_Property_SetInExternalFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT015_Associative_Function_UnmatchFunctionArgument_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT015_BasicImport_Middle()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT015_CountTrue_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT015_FFI_Transform_Identity()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT015_Inline_In_Class_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT015_LanguageBlockScope_ParallelInsideNestedBlock_AssociativeNested_II()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT015_Update_Of_Class_Properties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT016_Associative_Class_Property_SetInClassMethod()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT016_Associative_Function_ModifyArgumentInsideFunctionDoesNotAffectItsValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT016_BaseImportAssociative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT016_CountTrue_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT016_FFI_Transform_GetTuples()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT016_Inline_Using_Operators()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT016_LanguageBlockScope_ParallelInsideNestedBlock_ImperativeNested_AA()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT016_Update_Of_Variable_Types()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT017_Associative_Class_Property_SetInExternalClassMethod()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT017_Associative_Function_CallingAFunctionBeforeItsDeclaration()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT017_BaseImportWithVariableClassInstance_Associativity()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT017_CountTrue_Inline()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT017_FFI_Transform_GetData()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT017_Inline_In_Function_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT017_LanguageBlockScope_AssociativeNestedAssociative_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT017_Update_Of_Class_Instances()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT018_Associative_Class_Constructor_WithSameNameAndArgument_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT018_CountTrue_RangeExpression_01()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT018_CountTrue_RangeExpression_02()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT018_CountTrue_RangeExpression_03()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT018_FFI_Math_Trigonometric_Hyperbolic()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Ignore]

        [Test]
        public void DebugEQT018_Inline_Using_Recursion()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        [Ignore]
        public void DebugEQT018_LanguageBlockScope_ImperativeNestedImperaive_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT018_MultipleImport()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT018_Update_Inside_Class_Constructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT018_Update_Inside_Class_Constructor_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT019_Associative_Class_Constructor_Overloads_WithSameNameAndDifferentArgumentNumber()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT019_CountTrue_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT019_Defect_1456758()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT019_FFI_Math_Others()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT019_LanguageBlockScope_ImperativeNestedAssociative_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT019_MultipleImport_ClashFunctionClassRedifinition()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT019_Update_General()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_Arithmatic_List_And_List_Different_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_BasicGlobalFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_Class_In_Various_Scopes()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_Function_In_Assoc_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_NegativeSyntax_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_SimpleRangeExpression()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_Simple_1D_Collection_Assignment()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_Simple_Assignment_Slicing()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_String_IfElse_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_String_IfElse_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_String_IfElse_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_String_IfElse_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_String_IfElse_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_String_IfElse_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_String_IfElse_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_TestAllPassCondition()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_TestGCArray()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_TestImpInsideImp()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_TestNegativeSyntax_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_TestVariousTypes()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_Update_Variable_Across_Language_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT01_WhileBreakContinue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT020_Associative_Class_Constructor_Overloads_WithSameNameAndDifferentArgumenType()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT020_CountTrue_DynamicArray()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT020_LanguageBlockScope_AssociativeNestedImperative_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT020_MultipleImport_WithSameFunctionName()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT020_Nested_And_With_Range_Expr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT020_Update_Inside_Class_Constructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT020_Vector_ByCoordinates()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT021_Associative_Class_Constructor_UsingUserDefinedClassAsArgument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT021_CountTrue_ModifierStack()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT021_Defect_1457354()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT021_Defect_1457354_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT021_Defect_1457354_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT021_Defect_1467166_array_comparison_issue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT021_LanguageBlockScope_DeepNested_IAI_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT021_Update_Inside_Class_Constructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT021_Vector_ByCoordinates()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT022_Array_Marshal()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT022_Associative_Class_Constructor_AssignUserDefineProperties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT022_CountTrue_ImperativeAssociative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT022_Defect_1457740()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT022_Defect_1459905()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT022_Defect_1459905_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT022_Defect_1459905_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT022_Defect_1459905_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT022_LanguageBlockScope_DeepNested_AIA_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_Associative_Class_Constructor_CallingAFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_CountFalse_IfElse()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_Defect_1459789()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_Defect_1459789_10()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_Defect_1459789_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_Defect_1459789_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_Defect_1459789_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_Defect_1459789_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_Defect_1459789_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQT023_Defect_1459789_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        // Comment Jun: Aparajit to address why the testcase hangs NUnit whereas a normal run catches the cycle
        [Test, Ignore]
        public void DebugEQT023_Defect_1459789_8()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_Defect_1459789_9()
        {
            string code = @"
            //Assert.Fail("");
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT023_LanguageBlockScope_AssociativeParallelImperative_Function()
        {
            string code = @"
            //Assert.Fail("");
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT024_Associative_Class_Constructor_CallingAnImperativeFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT024_CountFalse_ForLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT024_Defect_1459470()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT024_Defect_1459470_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT024_Defect_1459470_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT024_Defect_1459470_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT024_LanguageBlockScope_ImperativeParallelAssociative_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT025_Associative_Class_Constructor_CallingAnotherConstructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT025_CountFalse_WhileLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT025_Defect_1459704()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT025_Defect_1459704_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT025_LanguageBlockScope_AssociativeParallelAssociative_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT026_Associative_Class_Constructor_BaseConstructorAssignProperties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT026_CountFalse_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT026_Defect_1459631()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT026_Defect_1459631_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT026_Defect_1459631_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT026_LanguageBlockScope_ImperativeParallelImperative_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT027_Associative_Class_Constructor_BaseConstructorWithSameName()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT027_CountFalse_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT027_Defect_1460741()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT027_Defect_1460741_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT027_LanguageBlockScope_MultipleParallelLanguageBlocks_AIA_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT028_Associative_Class_Property_DefaultAssignment()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT028_CountFalse_Inline()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT028_LanguageBlockScope_MultipleParallelLanguageBlocks_IAI_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT028_Modifier_Stack_Simple()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT029_Associative_Class_Property_AccessModifier()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT029_CountFalse_RangeExpression_01()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT029_CountFalse_RangeExpression_02()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT029_Defect_1460139_Update_In_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT029_LanguageBlockScope_ParallelInsideNestedBlock_AssociativeNested_II_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_Arithmatic_List_And_List_Same_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_Assignment_Slicing_Modify_Arguments()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_AssociativeBlock_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_Class_In_Various_Nested_Scopes()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_Collection_Assignment_Associative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_Function_In_Imp_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_GlobalFunctionWithDefaultArg()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_IfElseIf()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_SampleTestUsingCodeFromExternalFile__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_SampleTestUsingCodeFromExternalFile()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_SimpleRangeExpression()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_String_Not()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_TestAssocInsideImp()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_TestGCEndofIfBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_TestNegativeUsage_InAssociativeBlock_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_Update_Function_Argument_Across_Language_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT02_WhileBreakContinue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT030_Associative_Class_Property_AccessModifier()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT030_CountFalse_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT030_Defect_1467236_Update_In_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT030_Defect_1467236_Update_In_Class_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT030_LanguageBlockScope_ParallelInsideNestedBlock_ImperativeNested_AA()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT031_Associative_Class_Property_AccessModifier()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT031_CountFalse_DynamicArray()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT031_Defect_1450594()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT032_CountFalse_ModifierStack()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT032_Cross_Language_Variables()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT033_CountFalse_ImperativeAssociative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT033_Wrong_Spelling_Of_Language_Block()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT034_AllFalse_IfElse()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT035_AllFalse_ForLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT036_1_Null_Check()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT036_AllFalse_WhileLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT037_AllFalse_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT038_AllFalse_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT039_AllFalse_Inline()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_Arithmatic_Mixed()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_Assignment_Slicing_With_Collection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_Class_In_Various_Scopes()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_Collection_Assignment_Nested_Block()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_Defect_UndefinedType()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_ForLoopBreakContinue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_Function_In_Nested_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_GlobalFunctionInAssocBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_MultipleIfStatement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_SimpleRangeExpressionUsingCollection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_TestAssignmentToUndefinedVariables_negative__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_TestAssignmentToUndefinedVariables_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_TestGCEndofLangBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_TestImpInsideAssoc()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_TestNegativeUsage_InUnnamedBlock_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_UnnamedBlock_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT03_Update_Function_Argument_Across_Language_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT040_AllFalse_RangeExpression_01()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT040_AllFalse_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT042_AllFalse_DynamicArray()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT043_AllFalse_ModifierStack()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT044_AllFalse_ImperativeAssociative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT045_Defect_CountArray_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT045_Defect_CountArray_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT045_Defect_CountArray_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT046_Sum_IfElse()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT047_Sum_ForLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT048_Sum_WhileLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT049_Sum_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_Arithmatic_Single_List_And_Integer()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_Class_Properties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_Collection_Assignment_Using_Indexed_Values()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_Defect_1454320_String()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_Defect_1467100_String()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_ForLoopBreakContinue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_Function_In_Nested_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_GlobalFunctionInImperBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_IfStatementExpressions()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_OutsideBlock_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_SimpleRangeExpressionUsingFunctions()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_TestAssignmentStmtInExpression_negative__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_TestAssignmentStmtInExpression_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_TestGCReturnFromLangBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_TestImperativeBlockWithMissingBracket_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_TestNegativeUsage_OutsideBlock_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT04_Update_Class_Instance_Argument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT050_Sum_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT051_Inherit_defaultconstructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT051_Sum_Inline()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT052_Inherit_defaultproperty()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT052_Sum_RangeExpression()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT053_Inherit_changevalue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT053_Sum_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT054_Inherit_nested()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT054_Sum_DynamicArr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT055_Inherit_donotchangevalue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT055_Sum_ModifierStack()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT056_Inherit_private()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQT056_Sum_AssociativeImperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT057_Average_DataType_01()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT057_Inherit_private_modify()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT058_Average_DataType_02()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT058_Inherit_private_notmodify()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT059_Defect_Flatten_RangeExpression()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT059_Defect_Flatten_RangeExpression_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT059_Inherit_access_privatemember()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_ClassMemerVarAsFunctionPointer()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_ClassMemerVarAsFunctionPointerDefaultArg()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_Class_Properties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_Collection_Assignment_Using_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_FunctionBreakContinue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_Function_outside_Any_Block()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_InsideFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_Logic_List_And_List_Different_Value()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_RangeExpressionWithIncrement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_String_ForLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_TestForLoopInsideNestedBlocks()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_TestGCReturnFromFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_TestImperativeBlockWithMissingBracket_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_TestRepeatedAssignment()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_TestRepeatedAssignment_negative__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_TestRepeatedAssignment_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_Update_Class_Instance_Argument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT05_WithinFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT060_Average_ForLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT061_Average_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT061_Inherit_Property()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT062_Average_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT062_Inherit_classAsArgument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT063_Average_Inline()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT063_Inherit_classAsArgument_callinfunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT064_Average_RangeExpression()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT064_Inherit_classAsArgument_callinfunction_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT065_Average_ModifierStack()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT065_Inherit_constructor_withoutbase()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT066_Inherit_constructor_failing_witbase()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT066_Print_String()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT067_Inherit_propertynotassignedinbase()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT067_Print_Arr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT068_Inherit_propertyassignedinherited()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT069_Inherit_constructor_failing_both()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_ClassMemerVarAsFunctionPointerAssocBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_Class_Properties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_Collection_Assignment_Using_Class_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_Function_Imp_Inside_Assoc()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_InsideNestedBlock()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_Logic_List_And_List_Same_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_NestedIfElse()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_RangeExpressionWithIncrement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_String_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_TestGCEndofWhileBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_TestInUnnamedBlock_negative__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_TestInUnnamedBlock_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_TestInsideNestedBlocksUsingCollectionFromAssociativeBlock()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT06_TestNestedImpBlockWithMissingBracket_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQT06_Update_Class_Instance_Argument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT070_Inherit_constructor_failing_inherited()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT071_Inherit_constructor_failing_inherited_sameproperty()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT072_inherit_Class_Constructor_CallingAFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT073inherit_Constructor_WithSameNameAndDifferentArgumenType()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT074_Inherit_property_array()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT075_Inherit_property_array_modify()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT076_Inherit_property_array_modifyanitem()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT077_Inherit_property_thatdoesnotexist()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT078_Inherit_property_singletonconvertedtoarray()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_BreakStatement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_ClassMemerVarAsFunctionPointerImperBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_Class_Properties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_Collection_Assignment_In_Function_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_Function_Assoc_Inside_Imp()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_Logic_Mixed()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_RangeExpressionWithIncrementUsingFunctionCall()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_ScopeVariableInBlocks()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_String_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_String_Replication_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_String_Replication_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_TestBlockWithIncorrectBlockName_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_TestForLoopUsingLocalVariable()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_TestGCEndofForBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_TestOutsideBlock__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_TestOutsideBlock()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT07_Update_Array_Variable()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_Class_Properties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_Collection_Assignment_In_Function_Scope_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_ContinueStatement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_FunctionPointerUpdateTest()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_Function_From_Inside_Class_Constructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_Logic_Single_List_And_Value()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_NestedBlocks()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_RangeExpressionWithIncrementUsingVariables()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_String_Inline()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_String_Inline_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_TestBlockWithIncorrectBlockName_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_TestCyclicReference__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_TestCyclicReference()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_TestForLoopInsideFunctionDeclaration()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT08_TestGCArray02()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        // TODO Jun: Why does this testcase cycle until it crashes due to a null node at runtime?
        [Test, Ignore]
        public void DebugEQT08_Update_Array_Variable()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_2D_Collection_Assignment_In_Class_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_Class_Inheritance()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_Defect_1449829()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_Function_From_Inside_Class_Constructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_NegativeTest_Non_FunctionPointer()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_NestedIfElseInsideWhileStatement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_NestedWhileStatement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_Pass_1_single_list_of_class_type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_RangeExpressionWithApproximateIncrement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_Replication_On_Operators_In_Range_Expr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_String_DynamicArr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_TestForLoopWithBreakStatement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_TestGCPassingArguments()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_TestInNestedBlock__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT09_TestInNestedBlock()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQT09_Update_Across_Multiple_Imperative_Blocks()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT100_Class_inheritance_replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT100_Class_inheritance_replication_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_2D_Collection_Assignment_In_Function_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_Class_Inheritance()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_Defect_1449732()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_Function_From_Inside_Class_Method()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_NegativeTest_UsingFunctionNameAsVarName_Global()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_Pass_2_Lists_Different_Length_2_Integers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_RangeExpressionWithReplication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_String_ModifierStack()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_TestGCReturnArguments()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_TestInFunctionScope__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_TestInFunctionScope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_TestNestedForLoops()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_TypeConversion()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_Update_Array_Across_Multiple_Imperative_Blocks()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT10_WhilewithAssgnmtStatement_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_2D_Collection_Assignment_Heterogeneous()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_Class_Inheritance()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_Defect_1450174()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_Function_From_Inside_Class_Method()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_NegativeTest_UsingFunctionNameAsVarName_Global_ImperBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_Pass_2_lists_of_class_type_same_length_and_1_variable_of_class_type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_RangeExpressionUsingClasses()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_String_Imperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_TestForLoopWithSingleton()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_TestGCLangBlkInFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_TestIfElseUsingFunctionCall()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_TestInClassScope__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_TestInClassScope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_Update_Undefined_Variables()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT11_WhilewithLogicalOperators()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_Char_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_Collection_Assignment_Block_Return_Statement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_Defect_1450599()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_Function_From_Inside_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_NegativeTest_UsingGlobalFunctionNameAsMemVarName_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_Pass_2_Lists_Same_Length_1_Integer()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_RangeExpressionUsingNestedRangeExpressions()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_TestForLoopWith2DCollection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_TestGCIfElseInFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_TestIfElseUsingClassProperty()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_TestUsingMathAndLogicalExpr__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_TestUsingMathAndLogicalExpr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_Update_Undefined_Variables()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT12_WhileWithFunctionCall()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_2D_Collection_Assignment_Block_Return_Statement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_Class_Default_Constructors()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_Defect_1450527()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_DoWhileStatment_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_Function_From_Inside_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_GCTestComplexCase()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_IfElseIf()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_NegativeTest_UsingMemFunctionNameAsMemVarName_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_Pass_3_Lists_Different_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_RangeExpressionWithStartEndValuesUsingFunctionCall()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_TestForLoopWithNegativeAndDecimalCollection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_TestUsingMathAndLogicalExpr__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT13_TestUsingMathAndLogicalExpr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQT13_Update_Variables_Across_Blocks()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_2D_Collection_Assignment_Using_For_Loop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_Class_Named_Constructors()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_Defect_1450550()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_Defect_1461209()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_Defect_1461209_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_Defect_1461209_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_Defect_1461209_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_Function_Recursive_imperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_IfElseStatementExpressions()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_NegativeTest_UsingFunctionNameInNonAssignBinaryExpr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_Pass_3_Lists_Same_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_RangeExpressionUsingClassMethods()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_TestFactorialUsingWhileStmt()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_TestForLoopWithBooleanCollection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_TestUsingMathAndLogicalExpr__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT14_TestUsingMathAndLogicalExpr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_2D_Collection_Assignment_Using_While_Loop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_Class_Constructor_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_Defect_1452044()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_Defect_1460935()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_Defect_1460935_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_Defect_1460935_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_Defect_1460935_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_Defect_1460935_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_Defect_1460935_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_Function_From_Parallel_Blocks()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_NegativeTest_UsingFunctionNameInNonAssignBinaryExpr_Global_ImperBlk()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_Pass_a_3x3_and_2x4_lists()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_SimpleRangeExpression_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_TestEmptyIfStmt()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_TestForLoopWithMixedCollection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_TestInRecursiveFunctionScope__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_TestInRecursiveFunctionScope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT15_TestWhileWithDecimalvalues()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_Assigning_Class_Collection_Property()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_Class_Constructor_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_Defect_1460623()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_Defect_1460623_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_Defect_1460623_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_Defect_1460623_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_Function_From_Parallel_Blocks()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_NegativeTest_UsingMemFunctionAsFunctionPtr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_Pass_a_3x3_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_SimpleRangeExpression_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_TestForLoopInsideIfElseStatement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_TestIfConditionWithNegation_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_TestInvalidSyntax__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_TestInvalidSyntax()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16_TestWhileWithLogicalOperators()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT16__Defect_1452588()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_Assigning_Collection_And_Updating()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_Class_Constructor_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_Defect_1459759()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_Defect_1459759_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_Function_From_Parallel_Blocks()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_PassFunctionPointerAsArg()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_Pass_ConstructorCall_Return_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_SimpleRangeExpression_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_TestForLoopInsideNestedIfElseStatement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_TestInvalidSyntax__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_TestInvalidSyntax()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_TestWhileWithBool()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17_WhileInsideElse()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT17__Defect_1452588_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_Assigning_Collection_In_Function_And_Updating()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_Class_Constructor_Empty()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_FunctionPointerAsReturnVal()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_Function_Recursive_associative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_Pass_ConstructorCall_Return_List_to_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_SimpleRangeExpression_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_TestForLoopInsideWhileStatement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_TestMethodCallInExpr__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_TestMethodCallInExpr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_TestWhileWithNull()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQT18_Update_Variables_In_Inner_Assoc()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18_WhileInsideIf()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT18__Negative_Block_Syntax()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_Assigning_Collection_In_Function_And_Updating()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_BasicIfElseTestingWithNumbers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_Class_Constructor_Test_Default_Property_Values()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_Function_From_Imperative_While_And_For_Loops()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_Imperative_Nested_1467063()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_NegativeTest_PassingFunctionPtrAsArg_CSFFI()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_Pass_FunctionCall_Return_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_SimpleRangeExpression_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_TestAssignmentToCollection__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_TestAssignmentToCollection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_TestForLoopInsideNestedWhileStatement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_TestWhileWithIf()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT19_Update_Class_Properties_Thru_Methods()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_BasicIfElseTestingWithNumbers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Class_Constructor_Fails()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Defect_1458567()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Defect_1458567_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Defect_1461391()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Defect_1461391_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Defect_1461391_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Defect_1461391_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Defect_1461391_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Defect_1461391_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_FunctionPtrUpdateOnMemVar_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Function_From_Imperative_If_Block()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_Pass_Single_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_RangeExpressionsUsingPowerOperator()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_TestForLoopWithoutBracket()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_TestInvalidSyntax__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_TestInvalidSyntax()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT20_TestWhileToCreate2DimArray()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_Class_Constructor_Calling_Base_Constructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_Defect_1460891()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_Defect_1460891_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_Defect_1461390()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQT21_Defect_1461390_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_FunctionPtrUpdateOnMemVar_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_Function_From_Nested_Imperative_Loops()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_IfElseWithArray_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_Pass_Single_List_2_Integer()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_RangeExpressionsUsingEvenFunction()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_TestAssignmentToBool__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_TestAssignmentToBool()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_TestIfElseStatementInsideForLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT21_TestWhileToCallFunctionWithNoReturnType()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_Class_Constructor_Not_Calling_Base_Constructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_Create_Multi_Dim_Dynamic_Array()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_Defect_1463683()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_Defect_1463683_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_Defect_1463683_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_Defect_1463683_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_Function_Call_As_Instance_Arguments()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_IfElseWithArrayElements()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_Pass_1_single_list_of_class_type_and_1_variable_of_class_type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_RangeExpressionsUsingClassMethods_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_TestAssignmentToNegativeNumbers__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_TestAssignmentToNegativeNumbers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_TestWhileStatementInsideForLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT22_Update_Class_Instance()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Class_Constructor_Base_Constructor_Same_Name()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Create_Dynamic_Array_Using_Replication_In_Imperative_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Function_Call_As_Function_Call_Arguments()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Pass_2_lists_of_class_type_with_different_length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_RangeExpressionsUsingClassMethods_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_TestForLoopWithDummyCollection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_TestUsingMathAndLogicalExpr__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_TestUsingMathAndLogicalExpr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Update_Class_Instance_Using_Set_Method()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Update_Class_Instance_Using_Set_Method_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Update_Class_Instance_Using_Set_Method_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Update_Class_Instance_Using_Set_Method_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Update_Class_Instance_Using_Set_Method_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Update_Class_Instance_Using_Set_Method_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT23_Update_Class_Instance_Using_Set_Method_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Class_Constructor_Calling_Base_Methods()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Accessing_Out_Of_Bound_Index()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Argument_Function_1465802_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Argument_Function_1465802_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Class_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Class_Scope_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Class_Scope_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Imperative_Function_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Imperative_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Inside_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Inside_Function_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Passed_As_Int_Array_To_Class_Method()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Dynamic_Array_Passed_As_Primitive_Array_To_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Function_Call_In_Range_Expression()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Pass_3x3_List_And_2x4_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_TestForLoopToModifyCollection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_TestUsingMathematicalExpr__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_TestUsingMathematicalExpr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT24_Update_Variable_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_Elements_ToMemberOfClass_1465704_10()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_Elements_To_Array()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_Elements_To_Array_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_Elements_To_Array_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_elements_MemberClass_imperative_1465704_8()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_elements_MemberClass_imperative_1465704_9()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_elements_tomemberofclass_1465704()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_elements_tomemberofclass_1465704_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_elements_tomemberofclass_1465704_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_elements_tomemberofclass_1465704_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_elements_tomemberofclass_1465704_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_elements_tomemberofclass_1465704_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Adding_elements_tomemberofclass_1465704_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Class_Assignment_dynamic_imperative_1465637_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Class_Properties_Modifiers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Defect_1459759()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Defect_1459759_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Defect_1459759_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Defect_1459759_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Defect_1459759_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Defect_1459759_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Defect_1459759_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Function_Call_In_Mathematical_And_Logical_Expr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_Pass_3_List_Different_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_RangeExpression_WithDefaultDecrement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_RangeExpression_WithDefaultDecrement_1467121()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_RangeExpression_WithDefaultDecrement_nested_1467121_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_TestForLoopEmptyCollection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_TestUsingMathematicalExpr__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT25_TestUsingMathematicalExpr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Class_Properties_Access()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Defct_DNL_1459616()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Defct_DNL_1459616_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Defct_DNL_1459616_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Defct_DNL_1459616_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Defct_DNL_1459616_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Defect_1450854__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Defect_1450854()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Defect_1463663()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Function_Call_In_Mathematical_And_Logical_Expr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_IfElseWithNegatedCondition()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Negative_TestPropertyAccessOnPrimitive()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_Pass_3_List_Different_Length_2_Integers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_RangeExpression_Function_tilda_1457845()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_RangeExpression_Function_tilda_associative_1457845_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_RangeExpression_Function_tilda_multilanguage_1457845_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_TestForLoopOnNullObject()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_defect_1464429_DynamicArray()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT26_defect_1464429_DynamicArray_class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Class_Properties_Access()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Defect_1450847__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Defect_1450847()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_DynamicArray_Class_1465802_Argument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_DynamicArray_Class_1465802_Argument_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_DynamicArray_Class_1465802_member()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_DynamicArray_Invalid_Index_1465614_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_DynamicArray_Invalid_Index_1465614_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_DynamicArray_Invalid_Index_1467104()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_DynamicArray_Invalid_Index_1467104_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_DynamicArray_Invalid_Index_imperative_1467104_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Function_Call_Before_Declaration()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_Cross_Reference()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_Inside_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_Inside_Class_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_Inside_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_Update()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_Update_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_Update_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_Update_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_Update_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_Update_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Array()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Array_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Array_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Array_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Different_Types()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Different_Types_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Function_Call()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Function_Call_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Inline_Condition()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Range_Expr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Right_Assignment()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Modifier_Stack_With_Self_Updates()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_Pass_3_List_Same_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_RangeExpression_Function_Associative_1463472()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_RangeExpression_Function_Associative_1463472_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_RangeExpression_Function_Associative_replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_RangeExpression_Function_return_1463472()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_RangeExpression_class_return_1463472_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_TestCallingFunctionInsideForLoop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_defect_1464429_DynamicArray()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_defect_1464429_DynamicArray_class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_defect_1464429_DynamicArray_class_inherit()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_defect_1464429_DynamicArray_inline()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_defect_1464429_DynamicArray_memberof_class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT27_defect_1464429_DynamicArray_update()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT28_Class_Properties_Access()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT28_Defect_1452966()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT28_Function_Arguments_Declared_Before_Function_Def()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT28_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT28_Pass_3_List_Same_Length_2_Integers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT28_Update_With_Inline_Condition()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT28_Update_With_Inline_Condition_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT28_defect_1465706__DynamicArray_Imperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT28_defect_1465706__DynamicArray_Imperative_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT29_Class_Method_Chaining()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT29_Defect_1449887__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT29_Defect_1449887()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT29_Defect_1452966_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT29_DynamicArray_Using_Out_Of_Bound_Indices()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT29_Function_With_Different_Arguments()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT29_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT29_Pass_FunctionCall_Reutrn_List001()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_Class_Property_Update_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_Defect_1449887_2__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_Defect_1449887_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_ForLoopNull()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_Function_With_Mismatching_Return_Type_DS()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_Pass_FunctionCall_Reutrn_List002()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_Update_Global_Variables_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_Update_Global_Variables_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_Update_Global_Variables_Imperative_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT30_Update_Global_Variables_Imperative_Scope_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Class_By_Composition()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1449877__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1449877()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1459777()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1459777_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1459777_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1459777_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1459777_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1459777_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1459777_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1459777_8()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Defect_1459777_9()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_ForLoopSyntax01_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT31_Pass_FunctionCall_Reutrn_List003()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT32_Class_ReDeclaration()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT32_Defect_1449877_2__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT32_Defect_1449877_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT32_ForLoopSyntax02_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT32_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT32_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT32_Pass_Single_3x3_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT32_Update_With_Range_Expr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT33_Class_Methods()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT33_Defect_1450003__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT33_Defect_1450003()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT33_Defect_1466107()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT33_Defect_1466107_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT33_ForLoopToReplaceReplicationGuides()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT33_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT33_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT33_Pass_Single_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_Class_Static_Methods()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_Defect_1450727__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_Defect_1450727()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_Defect_1452966()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_Defect_DNL_1463327()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_Defect_DNL_1463327_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_Defect_DNL_1463327_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_Defect_DNL_1463327_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_IfElseSyntax_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT34_Pass_Single_List_2_Integers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT35_Class_Method_Overloading()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT35_Defect_1450727_2__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT35_Defect_1450727_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT35_Defect_1452966_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT35_Defect_DNL_1463700()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT35_Defect_DNL_1463700_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT35_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT35_IfElseWithEmptyBody()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT35_Pass_1_list_of_class_type_and_1_variable_of_class_type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT36_Class_Method_Calling_Constructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT36_Defect_1450555__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT36_Defect_1450555()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT36_Defect_1452966_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT36_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT36_IfElseInsideFunctionScope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT36_Modifier_Block_Multiple_Updates()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT36_Modifier_Block_Multiple_Updates_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT36_Pass_1_single_list_of_class_type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT37_Class_Method_Using_This()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT37_Defect_1450920()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT37_Defect_1454517()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT37_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT37_Modify_Collections_Referencing_Each_Other()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT37_Pass_2_lists_of_class_type_different_length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT37_TestOperationOnNullAndBool__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT37_TestOperationOnNullAndBool()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT38_Class_Method_Using_This()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT38_Defect_1449928__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT38_Defect_1449928()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT38_Defect_1450939()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT38_Defect_1454517_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT38_Defect_1454517_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT38_Defect_1467059_Modifier_Stack_With_Undefined_Variable()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT38_Defect_1467059_Modifier_Stack_With_Undefined_Variable_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT38_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT38_Pass_2_lists_of_class_type_different_length_and_1_integer()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Class_Method_Returning_Collection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Defect_1449704__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Defect_1449704()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Defect_1450920_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Defect_1452951()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Defect_1452951_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Defect_1452951_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Defect_1452951_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Defect_1465319_Modifier_Stack_Update_Issue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT39_Pass_2_lists_of_class_type_same_length_and_1_variable_of_class_type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Class_Property_Initialization_With_Another_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Create_3_Dim_Collection_Using_For_Loop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Defect_1450552__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Defect_1450552()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Defect_1450843()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Defect_1467057_Modifier_Stack_Cross_Update_Issue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Defect_1467057_Modifier_Stack_Cross_Update_Issue_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQT40_Defect_1467057_Modifier_Stack_Cross_Update_Issue_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Defect_1467057_Modifier_Stack_Update_Issue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Defect_1467088_Modifier_Stack_Cross_Update_Issue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Defect_1467088_Modifier_Stack_Cross_Update_Issue_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Defect_1467088_Modifier_Stack_Cross_Update_Issue_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Index_DynamicArray_1464942_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Index_DynamicArray_byarray_1464942_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Index_byFunction_argument_1467064_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Index_byFunction_class_imperative_1467064_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Index_usingFunction_1467064()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Index_usingFunction_class_1467064_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT40_Pass_2_List_of_class_type_Same_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Accessing_Non_Existent_Properties_From_Array_Elements()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Accessing_Non_Existent_Property_FromArray_1467083()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Accessing_Non_Existent_Property_FromArray_1467083_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Accessing_Non_Existent_Property_FromArray_1467083_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Create_3_Dim_Collection_Using_For_Loop_In_Func_Call()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Defect_1450778()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Defect_1467072_Class_Update()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Defect_1467072_Class_Update_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Pass_3x3_List_And_2x4_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Test_Static_Properties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41_Test_Static_Properties_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41__Defect_1452423__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT41__Defect_1452423()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT42_Create_3_Dim_Collection_Using_For_Loop_In_Class_Constructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT42_Defect_1449707()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT42_Defect_1461717()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT42_Defect_1466071_Cross_Update()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT42_Defect_1466071_Cross_Update_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT42_Defect_1466071_Cross_Update_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT42_Function_With_Mismatching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT42_Pass_3_List_Different_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT42__Defect_1452423_2__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT42__Defect_1452423_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Create_3_Dim_Collection_Using_For_Loop_In_Class_Method()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Create_CollectioninForLoop_1457172()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Create_CollectioninForLoop_1457172_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Defect_1450706()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Defect_1461479()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Defect_1461479_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Defect_1461479_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Defect_1461479_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Defect_1463498()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Function_With_Matching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43_Pass_3_List_Different_Length_2_Integers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43__Defect_1452423_3__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT43__Defect_1452423_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT44_Defect_1450706_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT44_Defect_1457029()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT44_Defect_1457029_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT44_Defect_1461860()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT44_Defect_1461860_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT44_Function_With_Null_Argument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT44_Pass_3_List_Same_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT44_Use_Bracket_Around_Range_Expr_In_For_Loop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT44__Defect_1452423_4__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT44__Defect_1452423_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT45_Defect_1450506()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT45_Defect_1458284()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT45_Defect_1461479()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT45_Function_With_Mismatching_Argument_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT45_Pass_3_List_Same_Length_2_Integers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT45__Defect_1452423_5__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT45__Defect_1452423_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT46_Defect_1461716()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT46_Defect_1461716_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT46_Function_With_Mismatching_Argument_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT46_Pass_FunctionCall_Reutrn_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT46_TestBooleanOperationOnNull__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT46_TestBooleanOperationOnNull()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT46_TestIfWithNull()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT47_Calling_Imperative_Code_From_Conctructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT47_Defect_1450858()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT47_Function_With_Mismatching_Argument_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT47_Pass_Single_3x3_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT47_TestBooleanOperationOnNull__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT47_TestBooleanOperationOnNull()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT48_Defect_1450858_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT48_Defect_1460027()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT48_Defect_1460027_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT48_Defect_1460027_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        // Ignore - Aparajit to fix testcase
        [Test, Ignore]
        public void DebugEQT48_Defect_1460027_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT48_Function_With_Mismatching_Argument_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT48_MultipleAssignments__2_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT48_MultipleAssignments()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT48_Pass_Single_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT49_Defect_1450783()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT49_Defect_1455264()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT49_Defect_1460505()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT49_Defect_1460505_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT49_Function_With_Matching_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT49_Pass_Single_List_2_Integers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT49_TestForStringObjectType()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT50_1_of_3_Exprs_is_List()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT50_Defect_1449889()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT50_Defect_1450817()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT50_Defect_1456713()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT50_Defect_1456738_Replication_Race_Condition()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT50_Defect_1460510()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT50_Defect_1460510_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT50_Function_With_Mismatching_Argument_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT50_Replication_Imperative_Scope()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT51_2_of_3_Exprs_are_Lists_Different_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT51_Assignment_Using_Negative_Index()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT51_Defect_1452588()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT51_Defect_1461399()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT51_Defect_1461399_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT51_Defect_1461399_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT51_Function_With_Mismatching_Argument_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT51_Using_Special_Characters_In_Identifiers()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT52_2_of_3_Exprs_are_Lists_Same_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT52_Defect_1449889()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT52_Defect_1452588_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT52_Defect_1461479()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT52_Defect_1461479_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT52_Defect_1461479_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT52_Defect_1461479_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT52_Defect_1461479_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT52_Function_With_Mismatching_Argument_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT52_Negative_Associative_Syntax()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_3_of_3_Exprs_are_different_dimension_list()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Collection_Indexing_On_LHS_Using_Function_Call()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Defect_1452575()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Defect_1454691()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Function_Updating_Argument_Values()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_As_Parameter()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_As_Parameter_1463738()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_As_Parameter_1463738_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_As_Parameter_1463738_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_As_Parameter_1463738_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_As_Parameter_1463738_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_As_Parameter_1463738_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_As_Parameter_1463738_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_As_Parameter_1463738_8()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_As_Parameter_imperative_1463738_9()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_negative_1467107_10()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_negative_associative_1467091_13()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_negative_imperative_1467091_12()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT53_Undefined_Class_negative_imperative_1467107_11()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT54_3_of_3_Exprs_are_Lists_Different_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT54_Associative_Nested_deffect_1467063()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT54_Defect_1451089()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT54_Defect_1454691()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT54_Defect_1458562()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT54_Defect_1467185_Modifier_Stack()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT54_Defect_1467185_Modifier_Stack_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT54_Defect_1467185_Modifier_Stack_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT54_Function_Updating_Argument_Values()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT55_3_of_3_Exprs_are_Lists_Same_Length()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT55_Associative_assign_If_condition_1467002()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT55_Defect_1450506()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT55_Defect_1454691()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT55_Defect_1460616()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT55_Defect_1460616_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT55_Function_Updating_Argument_Values()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT56_Defect_1454691()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT56_Defect_1460162()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT56_Function_Updating_Argument_Values()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT56_Local_Class_method_Same_Name_As_Global_Function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT56_UnaryOperator()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT57_Defect_1454691_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT57_Defect_1463742()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT57_Function_Using_Local_Var_As_Same_Name_As_Arg()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT57_Function_With_If_Else_But_No_Default_Return_Statement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT58_Defect_1450932_comparing_collection_with_singleton_Associative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT58_Defect_1450932_comparing_collection_with_singleton_Associative_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT58_Defect_1450932_comparing_collection_with_singleton_Associative_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT58_Defect_1450932_comparing_collection_with_singleton_Imperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT58_Defect_1454691_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT58_Defect_1462445()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT58_Defect_1462445_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT58_Function_With_No_Argument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT59_Defect_1453881()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT59_Defect_1453881_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT59_Defect_1455590()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT59_Defect_1466572()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT59_Defect_1466572_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT59_Defect_1466572_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT59_Function_With_No_Return_Stmt()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT60_Comparing_Class_Properties()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT60_Comparing_Class_Properties_With_Null()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT60_Defect_1455590_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT60_Defect_1467004()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT60_Function_With_No_Return_Stmt()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT61_Accessing_Non_Existent_Array_Properties_1467082()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT61_Accessing_Non_Existent_Array_Properties_1467082_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT61_Accessing_Non_Existent_Array_Properties_1467082_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT61_Accessing_non_existent_properties_of_array_elements()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT61_Assign_Non_Existent_Array_Properties_1467082_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT61_Assign_Non_Existent_Array_Properties_1467094()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT61_Defect_1459171()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT61_Function_With_Void_Return_Stmt()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT61_TestBooleanOperationOnNull()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Change_Avariable_To_Dynamic_Array_OnTheFly()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Class_Assignment_inside_imperative_1465637()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Condition_Not_Evaluate_ToBool()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Create_Dynamic_Array_OnTheFly()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Create_Dynamic_Array_OnTheFly_AsFunctionArgument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Create_Dynamic_Array_OnTheFly_inaClass()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Create_Dynamic_Array_OnTheFly_inaClass_methodoverload()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Create_Dynamic_Array_OnTheFly_passargument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Create_Dynamic_Array_OnTheFly_passargument_function()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Defect_1456721()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_Function_Modifying_Globals_Values()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT62_class_assignment_inside_imperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Class_methodresolution_1457172()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Class_methodresolution_1457172_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Class_methodresolution_1457172_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Create_MultiDimension_Dynamic_Array_OnTheFly()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Defect_1452643()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Dynamic_array_onthefly_1467066()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Dynamic_array_onthefly_aliastoanother()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Dynamic_array_onthefly_argument_class__1467139()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Dynamic_array_onthefly_function_1467139()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Dynamic_array_onthefly_function_return()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Dynamic_array_onthefly_update()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_Function_Modifying_Globals_Values()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT63_return_in_if_1467073()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT64_Defect_1450715()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT64_Function_Modifying_Globals_Values_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT64_Modify_itemInAnArray_1467093()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT64_Modify_itemInAnArray_1467093_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT65_Array_Alias_ByVal_1467165()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT65_Array_Alias_ByVal_1467165_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT65_Array_Alias_ByVal_1467165_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT65_Array_Alias_ByVal_1467165_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT65_Array_Alias_ByVal_1467165_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT65_Array_Alias_ByVal_1467165_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT65_Function_With_No_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT66_Array_CannotBeUsedToIndex1467069()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT66_Array_CannotBeUsedToIndex1467069_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT66_Function_Returning_Null()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT67_Array_Remove_Item()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT67_Array_Remove_Item_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT67_Function_Returning_Collection()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT68_Function_Returning_Null()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT68_Inherit_Base_Constructor_1467153()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT68_Inherit_Base_Constructor_1467153_negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT68_copy_byreference_1467105()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT69_Function_Name_Checking()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT69_Redefine_property_inherited_1467141()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT70_Defect_1467112_Method_Overloading_Issue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT70_Function_Name_Checking()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT71_Function_Name_Checking()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT71_class_inherit_arg_var_1467157()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT72_Function_Name_Checking()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT72_class_inherit_1467097()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT72_class_inherit_1467097_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT73_Function_Name_Checking_Negative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT74_Defect_1469099_Access_Property()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT74_Defect_1469099_Access_Property_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT74_Function_With_Simple_Replication_Associative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT74_Function_With_Simple_Replication_Imperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT75_Defect_1467188_Class_Instantiation()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT75_Defect_1467188_Class_Instantiation_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT75_Function_With_Replication_In_Two_Args()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT76_Defect_1467186_Class_Update()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT76_Function_With_Replication_In_One_Arg()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT77_Defect_1460274_Class_Update()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT77_Defect_1460274_Class_Update_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT77_Defect_1460274_Class_Update_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT77_Defect_1460274_Class_Update_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT77_Defect_1460274_Class_Update_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT77_Function_With_Simple_Replication_Guide()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT78_Defect_1467146_Class_Update_With_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT78_Defect_1467146_Class_Update_With_Replication_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT78_Defect_1467146_Class_Update_With_Replication_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT78_Defect_1467146_Class_Update_With_Replication_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT78_Defect_1467146_Class_Update_With_Replication_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT78_Function_call_By_Reference()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT79_Defect_1458581_Unnamed_Constructor()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT79_Function_call_By_Reference()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT80_Defect_1444246_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT80_Defect_1444246_Replication_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT80_Function_call_By_Reference()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT81_Defect_1467246_derived_class_setter()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT81_Function_Calling_Imp_From_Assoc()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT82_Defect_1467174()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT82_Function_Calling_Assoc_From_Imp()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT83_Function_With_Null_Arg()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT84_Function_With_User_Defined_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT85_Function_With_No_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT86_Function_With_For_Loop()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT87_Function_Returning_From_Imp_Block_Inside_Assoc()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT88_Function_With_Collection_Argument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT89_Function_With_Replication()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT90_Function_PassingNullToUserDefinedType()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT91_Function_With_Default_Arg()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT92_Function_With_Default_Arg_Overload()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQT93_Function_With_Default_Arg_In_Class()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA01_RangeExpressionWithIntegerIncrement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA02_RangeExpressionWithDecimalIncrement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA03_RangeExpressionWithNegativeIncrement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA04_RangeExpressionWithNullIncrement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA05_RangeExpressionWithBooleanIncrement()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA06_RangeExpressionWithIntegerTildeValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA07_RangeExpressionWithDecimalTildeValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA08_RangeExpressionWithNegativeTildeValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA09_RangeExpressionWithNullTildeValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA10_RangeExpressionWithBooleanTildeValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA11_RangeExpressionWithIntegerHashValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA12_RangeExpressionWithDecimalHashValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA13_RangeExpressionWithNegativeHashValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA14_RangeExpressionWithNullHashValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA15_RangeExpressionWithBooleanHashValue()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA16_RangeExpressionWithIncorrectLogic_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA17_RangeExpressionWithIncorrectLogic_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA18_RangeExpressionWithIncorrectLogic_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA19_RangeExpressionWithIncorrectLogic_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA20_RangeExpressionWithTripleDotOperator()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA21_Defect_1454692()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA21_Defect_1454692_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA21_Defect_1454692_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA21_Defect_1454692_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA22_Range_Expression_floating_point_conversion_1467127()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA22_Range_Expression_floating_point_conversion_1467127_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA23_Defect_1466085_Update_In_Range_Expr()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA23_Defect_1466085_Update_In_Range_Expr_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTA23_Defect_1466085_Update_In_Range_Expr_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV00_Function_With_If_Statements()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV01_Function_With_While_Statements()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV02_Function_With_For_Statements()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV03_Function_With_Recursion()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV04_Function_With_RangeExpression()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV05_Function_With_RangeExpression_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV06_Function_With_Logical_Operators()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV07_Function_With_Math_Operators()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV08_Function_With_Outer_Function_Calls()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV09_Function_With_Argument_Update_Imperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV101_Indexing_IntoArray_InFunctionCall_1463234()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV101_Indexing_IntoNested_FunctionCall_1463234_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV101_Indexing_Into_classCall_1463234_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV101_Indexing_Intoemptyarray_InFunctionCall_1463234_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV101_Indexing_Intosingle_InFunctionCall_1463234_()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV101_Indexing_Intosingle_InFunctionCall_1463234_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV101_Indexing_Intovariablenotarray_InFunctionCall_1463234_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV102_GlobalVariable_Function_1466768()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV102_GlobalVariable_Function_1466768_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV102_GlobalVariable_Function_1466768_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV103_Defect_1467149()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV104_Defect_1467112()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV10_Function_With_Class_Instances()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV11_Function_Update_Local_Variables()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV12_Function_With_Argument_Update_Associative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV13_Empty_Functions_Imperative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV14_Empty_Functions_Associative()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV15_Function_No_Brackets()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV16_Function_With_No_Return_Statement_DS()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV17_Function_Access_Local_Variables_Outside()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV18_Function_Access_Global_Variables_Inside()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV19_Function_Modify_Global_Variables_Inside()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV20_Function_With_Illegal_Syntax_1()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV21_Function_With_Illegal_Syntax_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV22_Function_With_Class_Object_As_Argument()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV23_Defect_1455152()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV24_Defect_1454958()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV25_Defect_1454923()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV26_Defect_1454923_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV27_Defect_1454688()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV28_Defect_1454688_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV29_Overloading_Different_Number_Of_Parameters()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV30_Overloading_Different_Parameter_Types()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV31_Overloading_Different_Return_Types()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV32_Function_With_Default_Argument_Value()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV32_Function_With_Default_Argument_Value_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV32_Function_With_Default_Argument_Value_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV33_Function_Overloading()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV33_Function_Overloading_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV33_Overloading_Different_Order_Of_Parameters()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV34_Implicit_Conversion_Int_To_Bool()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV35_Implicit_Conversion_Int_To_Double()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV36_Implicit_Conversion_Return_Type()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV37_Overloading_With_Type_Conversion()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV38_Defect_1449956()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV39_Defect_1449956_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV40_Defect_1449956_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV41_Defect_1454959()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV42_Defect_1454959()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV43_Defect_1455143()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV44_Defect_1455245()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV45_Defect_1455278()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV46_Defect_1455278()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV47_Defect_1456087()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV48_Defect_1456110()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQTV49_Defect_1456110()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }
        [Test, Ignore]
        public void DebugEQTV49_Defect_1456110_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV50_Defect_1456108()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV51_Defect_1456108_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV51_Defect_1456108_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV51_Defect_1456108_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV51_Defect_1456108_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV52_Defect_1456397()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV53_Defect_1456397_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV54_Defect_1456397_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV55_Defect_1456571()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV57_Defect_1454932()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV58_Defect_1455090()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV58_Defect_1455278()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV59_Defect_1455278()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV59_Defect_1455278_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV60_Defect_1455278_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV60_Defect_1455278_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV61_Defect_1455278_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV61_Defect_1455278_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV61_Defect_1456100()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV62_Defect_1455090()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV62_Defect_1456100()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV63_Defect_1455090_2()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV64_Defect_1455090_3()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV65_Defect_1455090_4()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV66_Defect_1455090_5()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV67_Defect_1455090_6()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV68_Defect_1455090_7()
        {
            string code = @"
            DebugTestFx.CompareDebugAndRunResults(code);
        }

        [Test]
        public void DebugEQTV69_Defect_1456799()
        {
            string code = @"
        }
