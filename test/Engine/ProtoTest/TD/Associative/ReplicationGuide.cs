using System;
using System.Collections.Generic;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoCore.Lang;
using ProtoTestFx.TD;
namespace ProtoTest.TD.Associative
{
    class ReplicationGuide
    {
        public TestFrameWork thisTest = new TestFrameWork();
        public string ReplicationRoot = "..\\..\\..\\Scripts\\TD\\Associative\\ReplicationGuide\\";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_a()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_2()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_3()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_4()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_5()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { new Object[] { 2, 4 } } }); // extra bracket is known issue for now
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_6()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_7()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { 2, 4 });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_8()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2.0, 3.0 }, new Object[] { 3.0, 4.0 } });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_9()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")] // negative testing
        public void T0001_Replication_Guide_Function_With_2_Arg_10()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] x1 = new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } };
            // verification : unknown
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_11()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] x1 = new Object[] { new Object[] { 2.0, 4.0 } };
            thisTest.Verify("test", new Object[] { x1 });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_12()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            // verification : unknown
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_14()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_15()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            // verification : clarify with new spec
            thisTest.Verify("test", new Object[] { 2, 4 });
        }

        [Test] //post R1
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_16()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            // verification : clarify with new spec
            thisTest.Verify("test", new Object[] { 2, 4 });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_17()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3, 4 }, new Object[] { 3, 4, 5 } });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_18()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 4, 5 }, new Object[] { 5, 6 }, new Object[] { 7, 8 } });
        }

        [Test]
        [Category("Replication")]
        public void T0001_Replication_Guide_Function_With_2_Arg_19()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { 4, 5 });
        }

        [Test]
        [Category("Replication")]
        public void T0002_Replication_Guide_Function_With_3_Arg()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] x1 = new Object[] { new Object[] { new Object[] { 6, 7 }, new Object[] { 7, 8 } }, new Object[] { new Object[] { 7, 8 }, new Object[] { 8, 9 } } };
            thisTest.Verify("test", x1);
        }

        [Test]
        [Category("Replication")]
        public void T0002_Replication_Guide_Function_With_3_Arg_2()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] x1 = new Object[] { new Object[] { 6, 7 }, new Object[] { 8, 9 } };

            thisTest.Verify("test", x1);
        }

        [Test] // post R1
        [Category("Replication")]
        public void T0002_Replication_Guide_Function_With_3_Arg_3()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] x1 = new Object[] { new Object[] { 6, 7 }, new Object[] { 8, 9 } };
            // verification : clarify with new spec
            thisTest.Verify("test", x1);
        }

        [Test]
        [Category("Replication")]
        public void T0002_Replication_Guide_Function_With_3_Arg_4()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] x1 = new Object[] { new Object[] { new Object[] { 6, 7 }, new Object[] { 7, 8 } }, new Object[] { new Object[] { 7, 8 }, new Object[] { 8, 9 } } };
            thisTest.Verify("test", x1);

        }

        [Test]
        [Category("Replication")]
        public void T0002_Replication_Guide_Function_With_3_Arg_5()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] x1 = new Object[] { new Object[] { new Object[] { 7, 8, 9, 10 }, new Object[] { 8, 9, 10, 11 }, new Object[] { 9, 10, 11, 12 } }, new Object[] { new Object[] { 8, 9, 10, 11 }, new Object[] { 9, 10, 11, 12 }, new Object[] { 10, 11, 12, 13 } } };
            thisTest.Verify("test", x1);
        }

        [Test]
        [Category("Replication")]
        public void T0003_Replication_Guide_Class_Constructor_With_2_Arg_1()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);

            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T0003_Replication_Guide_Class_Constructor_With_2_Arg_2()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T0003_Replication_Guide_Class_Constructor_With_2_Arg_3()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test] //post R1
        [Category("Replication")]
        public void T0003_Replication_Guide_Class_Constructor_With_2_Arg_4()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "DNL-1467459 NotImplemented Exception occurs when replication guides are used on a combination of collection and singleton";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new Object[] { 2, 3 });
        }

        [Test]
        [Category("Replication")]
        public void T0004_Replication_Guide_Class_Constructor_With_3_Arg()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] x1 = new Object[] { new Object[] { new Object[] { 6, 7 }, new Object[] { 7, 8 } }, new Object[] { new Object[] { 7, 8 }, new Object[] { 8, 9 } } };
            thisTest.Verify("test", x1);
        }

        [Test]
        [Category("Replication")]
        public void T0004_Replication_Guide_Class_Constructor_With_3_Arg_2()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] x1 = new Object[] { new Object[] { 6, 7 }, new Object[] { 8, 9 } };

            thisTest.Verify("test", x1);
        }

        [Test]
        [Category("Replication")]
        public void T0004_Replication_Guide_Class_Constructor_With_3_Arg_3()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] x1 = new Object[] { new Object[] { 6, 7 }, new Object[] { 8, 9 } };
            //Vericiation : clarify with new spec
            thisTest.Verify("test", x1);
        }

        [Test]
        [Category("Replication")]
        public void T032_replicationguide_usecase()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Object[] b = { 0, 1, 100, 3, 4, 5, 6, 7, 8, 9, 10 };
            Object[] d = { 0, 100, 4, 6, 8, 10 };
            thisTest.Verify("a", a);
            thisTest.Verify("b", b);
            thisTest.Verify("c", a);
            thisTest.Verify("d", d);
            thisTest.Verify("a_singleton", 10);
            thisTest.Verify("b_1DArray", new object[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 });

        }

        [Test]
        [Category("Replication")]
        public void T033_Replication_Guide_1467383()
        {
            String code =
                @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//1467383 - Validation Required -  [USER MANUAL] Select Trim Method Failure - Requested Coercion not implemented ";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 1.0, 1.0 }, new Object[] { 2.0, 2.0 } });
        }

        [Test]
        [Category("Replication")]
        public void T033_Replication_Guide_1467382()
        {
            String code =
                @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 0.0, 0.0 }, new Object[] { 1.0, 1.0 } });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments()
        {
            String code =
                @"def sum ( a, b, c)
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//DNL-1467386 Rev 4247 : WARNING: Replication unbox requested on Singleton warning coming from using replication guides on only some, not all arguments of a function gives incorrect output";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_a()
        {
            String code =
                @"def sum ( a, b, c)
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//DNL-1467386 Rev 4247 : WARNING: Replication unbox requested on Singleton warning coming from using replication guides on only some, not all arguments of a function gives incorrect output";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_b()
        {
            String code =
                @"def sum ( a, b, c)
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//DNL-1467386 Rev 4247 : WARNING: Replication unbox requested on Singleton warning coming from using replication guides on only some, not all arguments of a function gives incorrect output";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_c()
        {
            String code =
                @"def sum ( a, b, c)
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//DNL-1467386 Rev 4247 : WARNING: Replication unbox requested on Singleton warning coming from using replication guides on only some, not all arguments of a function gives incorrect output";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_2()
        {
            String code =
@"def sum ( a, b, c)
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//DNL-1467386 Rev 4247 : WARNING: Replication unbox requested on Singleton warning coming from using replication guides on only some, not all arguments of a function gives incorrect output";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_3()
        {
            String code =
@"def sum ( a, b, c)
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//DNL-1467386 Rev 4247 : WARNING: Replication unbox requested on Singleton warning coming from using replication guides on only some, not all arguments of a function gives incorrect output";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            //thisTest.Verify("test", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_4()
        {
            String code =
@"def sum ( a, b)
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { 2, 3 });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_5()
        {
            String code =
@"def sum ( a, b)
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { 2, 3 });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_6()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//DNL-1467386 Rev 4247 : WARNING: Replication unbox requested on Singleton warning coming from using replication guides on only some, not all arguments of a function gives incorrect output";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { 1, 2 });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_7()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//DNL-1467386 Rev 4247 : WARNING: Replication unbox requested on Singleton warning coming from using replication guides on only some, not all arguments of a function gives incorrect output";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("dummy", new Object[] { 2, 3 });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_8()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//DNL-1467386 Rev 4247 : WARNING: Replication unbox requested on Singleton warning coming from using replication guides on only some, not all arguments of a function gives incorrect output";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 0.0, 0.0 }, new Object[] { 1.0, 1.0 } });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_9()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 1.000, 9.500, 16.000 }, new Object[] { 11.000, 19.500, 26.000 } });
        }

        [Test]
        [Category("Replication")]
        public void T034_Replication_Guides_Not_On_All_Arguments_8_a()
        {

            //Analysis: The Rep Guides are being resolved to C0C1, rather than C1C2. This needs to
            //have the fix applied for function calls applied to ctors as well.
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";//DNL-1467386 Rev 4247 : WARNING: Replication unbox requested on Singleton warning coming from using replication guides on only some, not all arguments of a function gives incorrect output";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 0.0, 0.0 }, new Object[] { 1.0, 1.0 } });
        }

        [Test]
        [Category("Replication")]
        public void T035_Defect_1467317_Replication_Guide_On_Instances()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T035_Defect_1467317_Replication_Guide_On_Instances_2()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T035_Defect_1467317_Replication_Guide_On_Instances_3()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("test", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
            thisTest.Verify("test2", new Object[] { 2, 4 });
        }

        [Test]
        [Category("Replication")]
        public void T036_Defect_1467383_Replication_Guide_On_Collection()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            String errmsg = "";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.VerifyBuildWarningCount(0);
            thisTest.Verify("p", new Object[] { new Object[] { 1.0, 1.0 }, new Object[] { 2.0, 2.0 } });

        }


        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuideAfterArray()
        {
            string code = @"
            string errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("r", new object[] { new object[] { 5, 6 }, new object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuidebrackets_1467328()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("zArray1", new object[] { new object[] { 3.000000, 4.000000 }, new object[] { 5.000000, 6.000000 } });
        }

        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuidebrackets_1467328_2()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("e", new object[] { new object[] { 0, 100, 4, 6, 8, 10 }, new object[] { 100, 200, 104, 106, 108, 110 }, new object[] { 4, 104, 8, 10, 12, 14 }, new object[] { 6, 106, 10, 12, 14, 16 }, new object[] { 8, 108, 12, 14, 16, 18 }, new object[] { 10, 110, 14, 16, 18, 20 } });
        }

        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuidebrackets_1467328_3()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("x", new object[] { new object[] { 2, 3, 4 }, new object[] { 3, 4, 5 }, new object[] { 4, 5, 6 } });
        }

        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuidebrackets_1467328_4()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("x", new object[] { new object[] { 2, 3, 4 }, new object[] { 3, 4, 5 }, new object[] { 4, 5, 6 } });
        }

        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuidebrackets_1467328_5()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("list3", new object[] { new object[] { new object[] { new object[] { 1 }, new object[] { 2 } }, new object[] { new object[] { 2 }, new object[] { 4 } } }, new object[] { new object[] { new object[] { 2 }, new object[] { 4 } }, new object[] { new object[] { 4 }, new object[] { 8 } } } } );
        }

        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuidebrackets_1467328_6()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test2", new object[] { new object[] { 2, 3 }, new object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuidebrackets_1467328_7()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test2", new object[] { new object[] { 2, 3, 4, 5, 6 }, new object[] { 3, 4, 5, 6, 7 }, new object[] { 4, 5, 6, 7, 8 }, new object[] { 5, 6, 7, 8, 9 }, new object[] { 6, 7, 8, 9, 10 } }
);
        }

        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuidebrackets_1467328_8()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test2", new object[] { new object[] { 3.0, 4.0 }, new object[] { 5.0, 6.0 } }
);
        }

        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuidebrackets_1467328_9()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test2", new object[] { new object[] { 7, 9 }, new object[] { 8, 10 } }
);
        }

        [Test]
        [Category("Replication")]
        public void T037_ReplicationGuidebrackets_1467328_10()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test2", new object[] { new object[] { 7, 9 }, new object[] { 8, 10 } }
);
        }

        [Test]
        public void T037_ReplicationGuidebrackets_1467328_11()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test2", new object[] { new object[] { 7, 9 }, new object[] { 8, 10 } });
        }

        [Test]
        public void T037_ReplicationGuidebrackets_1467328_12()
        {
            string code = @"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test2", new object[] { new object[] { 0, 2, 4 }, new object[] { 2, 4, 6 }, new object[] { 4, 6, 8 } });
        }

        [Test]
        [Category("Replication")]
        public void T038_ReplicationGuide_Not_In_Sequence()
        {
            string code =
@"class A
            string errmsg = "DNL-1467460 NotImplemented Exception occurs when replication guides are not in sequence";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 2, 3 }, new object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_1()
        {
            string code =
@"def sum ( a, b, c)
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 5, 6 }, new object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_2()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 5, 6 }, new object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_3()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 5, 6 }, new object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_4()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 5, 6 }, new object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_5()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 5, 6 }, new object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_6()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { 0, 1, 2, 3, 4, 5, 6, 7 });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_7()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 5, 6 }, new object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_8()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_9()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 5, 6 }, new object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_10()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 5, 6 }, new object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T039_1467423_replication_guide_on_array_11()
        {
            string code =
@"
            string errmsg = "DNL-1467459 NotImplemented Exception occurs when replication guides are used on a combination of collection and singleton";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 5, 6 }, new object[] { 6, 7 } });
        }

        [Test]
        [Category("Replication")]
        public void T040_1467488_replication_guide_on_array_slices_1()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 0, 2, 4 }, new object[] { 2, 4, 6 }, new object[] { 4, 6, 8 } });
        }

        [Test]
        [Category("Replication")]
        public void T040_1467488_replication_guide_on_array_slices_2()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 2, 3 }, new object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T040_1467488_replication_guide_on_array_slices_3()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 2, 3 }, new object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T040_1467488_replication_guide_on_array_slices_4()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 2, 3 }, new object[] { 3, 4 } });
        }

        [Test]
        [Category("Replication")]
        public void T040_1467488_replication_guide_on_array_slices_5()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", 0);
            thisTest.Verify("test2", 2);
        }

        [Test]
        [Category("Replication")]
        public void T040_1467488_replication_guide_on_array_slices_6()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { 0, 1 });
            thisTest.Verify("test2", new object[] { 2, 3 });
        }

        [Test]
        [Category("Replication")]
        public void T040_1467488_replication_guide_on_array_slices_7()
        {
            string code =
@"
            string errmsg = "DNL-1467298 rev 4245 :  replication guides with partial array indexing is not giving the expected output";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { 0, 1 }, new object[] { 2, 3 } });

        }

        [Test]
        [Category("Replication")]
        public void T040_1467488_replication_guide_on_array_slices_8()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { 0, 3 });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_01()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_02()
        {
            string code =
@"
            string errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new Object[] { 2, 3 }, new Object[] { 2, 3 } });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_03()
        {
            string code =
@"
            string errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] t1 = new Object[] { new Object[] { 2, 2 }, new Object[] { 3, 3 } };
            thisTest.Verify("test", new object[] { t1, t1 });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_04()
        {
            string code =
@"
            string errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new Object[] { 2, 2 }, new Object[] { 3, 3 } });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_05()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new Object[] { 2, 2 }, new Object[] { 3, 3 } });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_06()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test", new object[] { new object[] { new object[] { 2, 2 }, new object[] { 2, 2 } }, new object[] { new object[] { 3, 3 }, new object[] { 3, 3 } } });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_07()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] t1 = new Object[] { new Object[] { 4, 4 }, new Object[] { 4, 4 } };
            Object[] t2 = new Object[] { new Object[] { 5, 5 }, new Object[] { 5, 5 } };
            thisTest.Verify("test", new object[] { t1, t2 });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_08()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] t1 = new Object[] { new Object[] { 2, 2 }, new Object[] { 2, 2 } };
            Object[] t2 = new Object[] { new Object[] { 3, 3 }, new Object[] { 3, 3 } };
            thisTest.Verify("test", new object[] { t1, t2 });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_09()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] t1 = new Object[] { new Object[] { 2, 2 }, new Object[] { 2, 2 } };
            Object[] t2 = new Object[] { new Object[] { 3, 3 }, new Object[] { 3, 3 } };
            thisTest.Verify("test", new object[] { t1, t2 });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_010()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] t1 = new Object[] { new Object[] { 2, 2 }, new Object[] { 2, 2 } };
            Object[] t2 = new Object[] { new Object[] { 3, 3 }, new Object[] { 3, 3 } };
            thisTest.Verify("test", new object[] { t1, t2 });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_011()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] t1 = new Object[] { new Object[] { 2, 2 }, new Object[] { 2, 2 } };
            Object[] t2 = new Object[] { new Object[] { 3, 3 }, new Object[] { 3, 3 } };
            thisTest.Verify("test", new object[] { t1, t2 });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_012()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            Object[] t1 = new Object[] { new Object[] { 2, 2 }, new Object[] { 2, 2 } };
            Object[] t2 = new Object[] { new Object[] { 3, 3 }, new Object[] { 3, 3 } };
            thisTest.Verify("test", new object[] { t1, t2 });
            thisTest.Verify("a2", new object[] { new Object[] { 2, 2, }, new Object[] { 3, 3 } });
            thisTest.Verify("a3", new object[] { new Object[] { 2, 3, }, new Object[] { 2, 3 } });
        }

        [Test]
        public void T041_1467460_replication_guide_not_in_sequence_013()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new Object[] { 2, 2, }, new Object[] { 3, 3 } });
            thisTest.Verify("test2", new object[] { new Object[] { 2, 3, }, new Object[] { 2, 3 } });
        }

        [Test]
        public void T042_1467555_cartesion_product_in_dot_operation_1()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new Object[] { 2, 2, }, new Object[] { 3, 3 } });
            thisTest.Verify("test2", new object[] { new Object[] { 2, 3, }, new Object[] { 2, 3 } });
        }

        [Test]
        public void T0100_FuncCall_Int_AllGuides()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } }, new object[] { new object[] { 7, 8 }, new object[] { 8, 9 } } });
            thisTest.Verify("test2", new object[] { new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } }, new object[] { new object[] { 7, 8 }, new object[] { 8, 9 } } });
            thisTest.Verify("test3", new object[] { new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } }, new object[] { new object[] { 7, 8 }, new object[] { 8, 9 } } });
            thisTest.Verify("test4", new object[] { new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } }, new object[] { new object[] { 7, 8 }, new object[] { 8, 9 } } });

        }

        [Test]
        public void T0101_FuncCall_Double_SomeGuides()
        {
            string code =
@"
            string errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { 6.0, 7.0 }, new object[] { 7.0, 8.0 } }, new object[] { new object[] { 7.0, 8.0 }, new object[] { 8.0, 9.0 } } });
            thisTest.Verify("test2", new object[] { new object[] { new object[] { 6.0, 7.0 }, new object[] { 7.0, 8.0 } }, new object[] { new object[] { 7.0, 8.0 }, new object[] { 8.0, 9.0 } } });
            thisTest.Verify("test3", new object[] { new object[] { new object[] { 6.0, 7.0 }, new object[] { 7.0, 8.0 } }, new object[] { new object[] { 7.0, 8.0 }, new object[] { 8.0, 9.0 } } });
            thisTest.Verify("test4", new object[] { new object[] { new object[] { 6.0, 7.0 }, new object[] { 7.0, 8.0 } }, new object[] { new object[] { 7.0, 8.0 }, new object[] { 8.0, 9.0 } } });

        }

        [Test]
        public void T0102_FuncCall_Double_SomeGuides()
        {
            string code =
@"
            string errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { 6.0, 7.0 }, new object[] { 8.0, 9.0 } });
            thisTest.Verify("test2", new object[] { new object[] { 6.0, 7.0 }, new object[] { 8.0, 9.0 } });
            thisTest.Verify("test3", new object[] { new object[] { 6.0, 7.0 }, new object[] { 8.0, 9.0 } });
            thisTest.Verify("test4", new object[] { new object[] { 6.0, 7.0 }, new object[] { 8.0, 9.0 } });
        }

        [Test]
        public void T0103_FuncCall_Bool_NotInSeq()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { false, false }, new object[] { true, true } }, new object[] { new object[] { true, true }, new object[] { true, true } } });
            thisTest.Verify("test2", new object[] { new object[] { new object[] { false, false }, new object[] { true, true } }, new object[] { new object[] { true, true }, new object[] { true, true } } });
            thisTest.Verify("test3", new object[] { new object[] { new object[] { false, false }, new object[] { true, true } }, new object[] { new object[] { true, true }, new object[] { true, true } } });
            thisTest.Verify("test4", new object[] { new object[] { new object[] { false, false }, new object[] { true, true } }, new object[] { new object[] { true, true }, new object[] { true, true } } });

        }

        [Test]
        public void T0104_FuncCall_Bool_NotInSeq()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { false, false }, new object[] { true, true } }, new object[] { new object[] { true, true }, new object[] { true, true } } });
            thisTest.Verify("test2", new object[] { new object[] { new object[] { false, false }, new object[] { true, true } }, new object[] { new object[] { true, true }, new object[] { true, true } } });
            thisTest.Verify("test3", new object[] { new object[] { new object[] { false, false }, new object[] { true, true } }, new object[] { new object[] { true, true }, new object[] { true, true } } });
            thisTest.Verify("test4", new object[] { new object[] { new object[] { false, false }, new object[] { true, true } }, new object[] { new object[] { true, true }, new object[] { true, true } } });

        }

        [Test]
        public void T0105_FuncCall_Int_NotAllGuides_NotInSeq()
        {
            string code =
@"
            string errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { 6, 8 }, new object[] { 7, 9 } });
            thisTest.Verify("test2", new object[] { new object[] { 6, 8 }, new object[] { 7, 9 } });
            thisTest.Verify("test3", new object[] { new object[] { 6, 8 }, new object[] { 7, 9 } });
            thisTest.Verify("test4", new object[] { new object[] { 6, 8 }, new object[] { 7, 9 } });
        }

        [Test]
        public void T0106_FuncCall_Int_MultipleGuides()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });
            thisTest.Verify("test2", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });
            thisTest.Verify("test3", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });
            thisTest.Verify("test4", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });
        }

        [Test]
        public void T0107_FuncCall_Int_MultipleGuides_NotAllInSeq()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 5, 6 } }, new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } }, new object[] { new object[] { 8, 9 }, new object[] { 9, 10 } } } });
            thisTest.Verify("test2", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 5, 6 } }, new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } }, new object[] { new object[] { 8, 9 }, new object[] { 9, 10 } } } });
            thisTest.Verify("test3", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 5, 6 } }, new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } }, new object[] { new object[] { 8, 9 }, new object[] { 9, 10 } } } });
            thisTest.Verify("test4", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 5, 6 } }, new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 7, 8 } }, new object[] { new object[] { 8, 9 }, new object[] { 9, 10 } } } });

        }

        [Test]
        public void T0108_FuncCall_Int_MultipleGuides_NotAllInSeq()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });
            thisTest.Verify("test2", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });
            thisTest.Verify("test3", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });
            thisTest.Verify("test4", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });

        }

        [Test]
        public void T0109_FuncCall_Int_MultipleGuides_NotAllInSeq()
        {
            string code =
@"
            string errmsg = "DNL-1467581 NotImplemented Exception when multiple non-sequential replication guides are used on multidimensional arrays";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });
        }

        [Test]
        public void T0110_FuncCall_Int_MultipleGuides_NotAllInSeq()
        {
            string code =
@"
            string errmsg = "DNL-1467581 NotImplemented Exception when multiple non-sequential replication guides are used on multidimensional arrays";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });
        }

        [Test]
        public void T0111_FuncCall_Int_MultipleGuides_NotAllInSeq()
        {
            string code =
@"
            string errmsg = "DNL-1467581 NotImplemented Exception when multiple non-sequential replication guides are used on multidimensional arrays";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } }, new object[] { new object[] { new object[] { 6, 7 }, new object[] { 8, 9 } }, new object[] { new object[] { 7, 8 }, new object[] { 9, 10 } } } });
        }

        [Test]
        public void T0112_FuncCall_Int_SingleAndMultipleGuides()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } });
            thisTest.Verify("test2", new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } });
            thisTest.Verify("test3", new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } });
            thisTest.Verify("test4", new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } });
        }

        [Test]
        public void T0113_FuncCall_Int_SingleAndMultipleGuides_NotInSeq()
        {
            string code =
@"
            string errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } });
            thisTest.Verify("test2", new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } });
            thisTest.Verify("test3", new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } });
            thisTest.Verify("test4", new object[] { new object[] { new object[] { 4, 5 }, new object[] { 6, 7 } }, new object[] { new object[] { 5, 6 }, new object[] { 7, 8 } } });

        }

        [Test]
        public void T0114_FuncCall_Int_SingleAndMultipleGuides_NotInSeq()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { 4, 5 }, new object[] { 7, 8 } });
        }

        [Test]
        public void T0115_FuncCall_HeterogenousInput()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { 2, 3 }, new object[] { 3, 4 } });
        }

        [Test]
        public void T0116_FuncCall_HeterogenousInput_MultipleGuides()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { 2.0, 3.0 }, new object[] { 5.0, 6.0 } });
        }

        [Test]
        public void T0117_FuncCall_HeterogenousInput_MultipleGuides()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { new object[] { 4.0, 5.0 }, new object[] { 6.0, 7.0 } }, new object[] { new object[] { 5.0, 6.0 }, new object[] { 7.0, 8.0 } } }, new object[] { new object[] { new object[] { 6.0, 7.0 }, new object[] { 8.0, 9.0 } }, new object[] { new object[] { 7.0, 8.0 }, new object[] { 9.0, 10.0 } } } });
        }

        [Test]
        public void T0118_FuncCall_HeterogenousInput_SingleGuides()
        {
            string code =
@" 
            string errmsg = "DNL-1467583 Unexpected runtime warning from using partial Replication Guides on heterogeneous arrays";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { 2.0, 4.0 });
        }

        [Test]
        public void T0119_FuncCall_HeterogenousInput_SingleGuides()
        {
            string code =
@" 
            string errmsg = "DNL-1467580 IndexOutOfRange Exception when replication guides are not applied on all arguments";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { 6.0, 7.0 }, new object[] { 8.0, 9.0 } });
        }

        [Test]
        public void T0120_FuncCall_HeterogenousInput_jagged_SingleGuides()
        {
            string code =
@" 
            // This is just a sample test case of replication guides on jagged array. Replication on jagged array is not yet defined properly
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { 6.0, 7.0 }, new object[] { 7.0, 8.0 } } });
        }

        [Test]
        public void T0121_InstanceCall_Int_SingleGuides()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new object[] { new object[] { new object[] { 9, 10 }, new object[] { 10, 11 } }, new object[] { new object[] { 10, 11 }, new object[] { 11, 12 } } });
        }

        [Test]
        public void T0122_ReplicationGudes_Inside_ClassAndFunctionBody()
        {
            string code =
@" 
            string errmsg = "DNL-1467585 ArgumentOutOfRange Exception : [Design Issue]when replication guides are used on more than 3 arguments in direct addition";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new Object[] { new Object[] { 6, 7 }, new Object[] { 8, 9 } });
            thisTest.Verify("test2", null);
            thisTest.Verify("test3", new Object[] { new Object[] { 6, 7 }, new Object[] { 8, 9 } });
            thisTest.Verify("test4", new Object[] { new Object[] { 6, 7 }, new Object[] { 8, 9 } });
            thisTest.Verify("test5", new Object[] { new Object[] { 6, 7 }, new Object[] { 8, 9 } });
            thisTest.Verify("test6", new Object[] { new Object[] { 6, 7 }, new Object[] { 8, 9 } });
            thisTest.Verify("test7", new Object[] { new Object[] { 6, 7 }, new Object[] { 8, 9 } });
        }

        [Test]
        public void T0123_Replication_BuiltinMethods()
        {
            string code =
@" 
            string errmsg = "DNL-1467587 'Contains' and 'Insert' definition in 'help'  does not match with actual implementation";
            thisTest.VerifyRunScriptSource(code, errmsg);

            thisTest.Verify("test1", new Object[] { true, true });
            thisTest.Verify("test2", new Object[] { 0, 1 });
            thisTest.Verify("test3", new Object[] { new Object[] { 1, 2, 3 }, new Object[] { 0, 2, 3 } });
            thisTest.Verify("test4", new Object[] { new Object[] { 0, 0, 1, 2, 3 }, new Object[] { 0, 1, 1, 2, 3 } });
            thisTest.Verify("test5", new Object[] { null, new Object[] { 0, 1, 2, 3 } });
            thisTest.Verify("test6", new Object[] { new Object[] { 0, 1, 2, 3 }, new Object[] { } });
            thisTest.Verify("test7", new Object[] { new Object[] { 3, 2, 1, 0 }, new Object[] { 0, 1, 2, 3 } });
            thisTest.Verify("test8", new Object[] { 0.5, 0.5 });

        }

        [Test]
        public void T0124_ReplicationGuides_BuiltinMethods()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new Object[] { new Object[] { true, true }, new Object[] { false, false } });
            thisTest.Verify("test2", new Object[] { new Object[] { 0, 1 }, new Object[] { -1, -1 } });
            thisTest.Verify("test3", new Object[] { new Object[] { new Object[] { 1 }, new Object[] { 0 } }, new Object[] { new Object[] { 3 }, new Object[] { 2 } } });
            thisTest.Verify("test4", new Object[] { new Object[] { new Object[] { 0, 0, 1 }, new Object[] { 0, 1, 1 } }, new Object[] { new Object[] { 0, 2, 3 }, new Object[] { 2, 1, 3 } } });
            thisTest.Verify("test5", new Object[] { new Object[] { null, new Object[] { 0, 1 } }, new Object[] { null, new Object[] { 2, 3 } } });
            thisTest.Verify("test6", new Object[] { new Object[] { new Object[] { 0, 1 }, new Object[] { } }, new Object[] { new Object[] { 2, 3 }, new Object[] { } } });
            thisTest.Verify("test7", new Object[] { new Object[] { new Object[] { 1, 0 }, new Object[] { 0, 1 } }, new Object[] { new Object[] { 1, 0 }, new Object[] { 0, 1 } } });
            thisTest.Verify("test8", new Object[] { new Object[] { 0.25, 0.4 }, new Object[] { 0.0, 0.25 } });
        }

        [Test]
        public void T0125_ReplicationGudes_MathFunctions()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new Object[] { 0, 1 });
            thisTest.Verify("test2", new Object[] { new Object[] { 0, 0 }, new Object[] { 0, 1 }, new Object[] { 0, 1 }, new Object[] { 0, 1 } });
            thisTest.Verify("test3", new Object[] { 0, 1 });
            thisTest.Verify("test4", new Object[] { new Object[] { 0, 1 }, new Object[] { 1, 1 }, new Object[] { 2, 2 }, new Object[] { 3, 3 } });
        }

        [Test]
        public void T0126_ReplicationGudes_ModifierBlock()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new Object[] { new Object[] { true, true }, new Object[] { false, false } });
            thisTest.Verify("test2", new Object[] { new Object[] { 0, 1 }, new Object[] { -1, -1 } });
            thisTest.Verify("test3", new Object[] { new Object[] { new Object[] { 1 }, new Object[] { 0 } }, new Object[] { new Object[] { 3 }, new Object[] { 2 } } });
            thisTest.Verify("test4", new Object[] { new Object[] { new Object[] { 0, 0, 1 }, new Object[] { 0, 1, 1 } }, new Object[] { new Object[] { 0, 2, 3 }, new Object[] { 2, 1, 3 } } });
            thisTest.Verify("test5", new Object[] { new Object[] { null, new Object[] { 0, 1 } }, new Object[] { null, new Object[] { 2, 3 } } });
            thisTest.Verify("test6", new Object[] { new Object[] { new Object[] { 0, 1 }, new Object[] { } }, new Object[] { new Object[] { 2, 3 }, new Object[] { } } });
            thisTest.Verify("test7", new Object[] { new Object[] { new Object[] { 1, 0 }, new Object[] { 0, 1 } }, new Object[] { new Object[] { 1, 0 }, new Object[] { 0, 1 } } });
            thisTest.Verify("test8", new Object[] { new Object[] { 0.25, 0.4 }, new Object[] { 0.0, 0.25 } });
        }

        [Test]
        public void T0127_ReplicationGudes_ModifierBlock()
        {
            string code =
@" 
            string errmsg = "DNL-1467586 Runtime warning with null value returned when replication guides are used of the form {a,a}.foo(x<1>,y<2>)";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("test1", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
            thisTest.Verify("test2", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
            thisTest.Verify("test3", new Object[] { 2, 4 });
            thisTest.Verify("test4", new Object[] { new Object[] { 2, 4 }, new Object[] { 3, 5 } });
            thisTest.Verify("test5", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
            //thisTest.Verify("test6", new Object[] { new Object[] { new Object[] { 0, 1 }, new Object[] { } }, new Object[] { new Object[] { 2, 3 }, new Object[] { } } });
            thisTest.Verify("test7", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
        }

        [Test]
        public void T0128_ReplicationGudes_InlineCondition()
        {
            string code =
@" 
            string errmsg = "DNL-1467589 Replication guide: Usage of Math function as a function argument with replication guides is yielding unexpected null values";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("a", new Object[] { new Object[] { 12, 13 }, new Object[] { 13, 14 } });
            thisTest.Verify("b", 2);
            thisTest.Verify("c3", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
            thisTest.Verify("c4", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
            thisTest.Verify("t1", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
            thisTest.Verify("t2", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
            thisTest.Verify("t3", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
            thisTest.Verify("t4", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });
            thisTest.Verify("t5", new Object[] { new Object[] { 5, 6 }, new Object[] { 6, 7 } });

        }

        [Test]
        public void T0129_ReplicationGudes_InlineCondition()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("t1", new Object[] { new Object[] { 4, 5 }, new Object[] { 5, 6 } });
        }

        [Test]
        public void T0130_ReplicationGudes_InlineCondition()
        {
            string code =
@" 
            string errmsg = "DNL-1467591 replication guides in class instantiation is not giving expected output";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("t1", new Object[] { new Object[] { 4, 5 }, new Object[] { 5, 6 } });
        }

        [Test]
        public void T0131_ReplicationGudes_InlineCondition()
        {
            string code =
@" 
            string errmsg = "DNL-1467591 replication guides in class instantiation is not giving expected output";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("t1", new Object[] { new Object[] { 4, 5 }, new Object[] { 5, 6 } });
        }

        [Test]
        public void T0132_ReplicationGudes_InlineCondition()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("t1", new Object[] { new Object[] { new Object[] { 9, 10 }, new Object[] { 10, 11 } }, new Object[] { new Object[] { 10, 11 }, new Object[] { 11, 12 } } });
            thisTest.Verify("t2", new Object[] { new Object[] { 6, 7 }, new Object[] { 7, 8 } });
            thisTest.Verify("t3", new Object[] { new Object[] { new Object[] { 9, 10 }, new Object[] { 10, 11 } }, new Object[] { new Object[] { 10, 11 }, new Object[] { 11, 12 } } });
            thisTest.Verify("t4", new Object[] { new Object[] { 6, 7 }, new Object[] { 7, 8 } });
        }

        [Test]
        public void T0133_ReplicationGudes_RangeExpr()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("t1", new Object[] { 0, 1, 2 });
            thisTest.Verify("t2", new Object[] { 2, 3, 4 });
            thisTest.Verify("t3", new Object[] { 0, 1, 2 });
            thisTest.Verify("t4", new Object[] { 2, 3, 4 });
        }

        [Test]
        public void T0134_ReplicationGudes_RangeExpr()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("t1", new Object[] { 0, 1, 2 });
            thisTest.Verify("t2", new Object[] { 0, 1, 2 });
            thisTest.Verify("t3", new Object[] { 0, 1, 2 });
            thisTest.Verify("t4", new Object[] { 0, 1, 2 });
        }

        [Test]
        public void T0135_ReplicationGudes_ArraySlicingScope()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("b", new Object[] { 1, 2, 3 });
            thisTest.Verify("c", new Object[] { 1, 2, 3 });
            thisTest.Verify("d", new Object[] { 1, 2, 3 });
            thisTest.Verify("f", new Object[] { 1, 2, 3 });
        }

        [Test]
        public void T0136_ReplicationGudes_ArraySlicingScope()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("b", new Object[] { 1, 3, 6 });
        }

        [Test]
        public void T0137_ReplicationGudes_RelationalOperators()
        {
            string code =
@" 
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("c1", new Object[] { new Object[] { 0, 0 }, new Object[] { 0, 0 } });
            thisTest.Verify("c2", new Object[] { new Object[] { true, true }, new Object[] { true, true } });
            thisTest.Verify("c3", new Object[] { new Object[] { 0, 0 }, new Object[] { 0, 0 } });
            thisTest.Verify("c4", new Object[] { new Object[] { 1, 1 }, new Object[] { 1, 1 } });
        }

        [Test]
        public void T0138_ReplicationGudes_LogicalOperators()
        {
            string code =
@" 
            string errmsg = "DNL-1467593 Support for some logical operators like | & ^ ~ missing"; // because of this defect, the above lines are commented out

            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("c1", new Object[] { new Object[] { false, false }, new Object[] { false, false } });
            thisTest.Verify("c2", new Object[] { true, true });
        }

        [Test]
        public void T0139_ReplicationGudes_MathematicalOperators()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("c1", new Object[] { new Object[] { 4, 6 }, new Object[] { 8, 10 } });
            thisTest.Verify("c2", new Object[] { new Object[] { new Object[] { new Object[] { -4, -5 }, new Object[] { -6, -7 } }, new Object[] { new Object[] { -3, -4 }, new Object[] { -5, -6 } } }, new Object[] { new Object[] { new Object[] { -2, -3 }, new Object[] { -4, -5 } }, new Object[] { new Object[] { -1, -2 }, new Object[] { -3, -4 } } } });
            thisTest.Verify("c3", new Object[] { new Object[] { 0.0, 0.2 }, new Object[] { 0.33333333333333331, 0.42857142857142855 } });
            thisTest.Verify("c4", new Object[] { new Object[] { new Object[] { 0, 5 }, new Object[] { 0, 7 } }, new Object[] { new Object[] { 8, 15 }, new Object[] { 12, 21 } } });
            thisTest.Verify("c5", new Object[] { new Object[] { 0, 1 }, new Object[] { 2, 3 } });
        }

        [Test]
        public void T0140_ReplicationGudes_StringConcat()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("c", new Object[] { new Object[] { "13", "14" }, new Object[] { "23", "24" } });
        }

        [Test]
        public void T0141_ReplicationGudes_LogicalOperators()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("c", new Object[] { new Object[] { 0, 0 }, new Object[] { 0, 0 } });
            thisTest.Verify("d", new Object[] { new Object[] { 0, 0 }, new Object[] { 0, 0 } });
            thisTest.Verify("f", new Object[] { new Object[] { new Object[] { new Object[] { 0, 0 }, new Object[] { 0, 0 } }, new Object[] { new Object[] { 0, 0 }, new Object[] { 0, 0 } } }, new Object[] { new Object[] { new Object[] { 0, 0 }, new Object[] { 0, 0 } }, new Object[] { new Object[] { 0, 0 }, new Object[] { 0, 0 } } } });
        }

        [Test]
        public void T0142_ReplicationGudes_On_Both_Instance_And_Method_Call()
        {
            string code =
@"
            string errmsg = "";
            thisTest.VerifyRunScriptSource(code, errmsg);
            thisTest.Verify("t1", new Object[] { 2, 3, 2, 3, 2, 3, 2, 3 });
            thisTest.Verify("t2", new Object[] { 2, 4 });
            thisTest.Verify("t3", new Object[] { new Object[] { 2, 4 }, new Object[] { 2, 4 } });
            thisTest.Verify("t4", new Object[] { 2, 4 });
            thisTest.Verify("t5", new Object[] { 0, 1 });
            thisTest.Verify("t6", new Object[] { new Object[] { 0, 1 }, new Object[] { 0, 1 } });
        }

        [Test]
        public void T0143_ReplicationGudes_On_Both_Instance_And_Method_Call()
        {
            string code =
@"
            string errmsg = "DNL-1467586 Runtime warning with null value returned when replication guides are used of the form {a,a}.foo(x<1>,y<2>)";
            thisTest.VerifyRunScriptSource(code, errmsg);

            thisTest.Verify("t2", new Object[] { 2, 4 });
            thisTest.Verify("t3", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
            thisTest.Verify("t4", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
            thisTest.Verify("t5", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
            thisTest.Verify("t6", new Object[] { new Object[] { 2, 3 }, new Object[] { 3, 4 } });
            thisTest.Verify("t7", new Object[] { new Object[] { 2, 4 }, new Object[] { 2, 4 } });
            thisTest.Verify("t8", new Object[] { 2, 4 });
        }
    }
}