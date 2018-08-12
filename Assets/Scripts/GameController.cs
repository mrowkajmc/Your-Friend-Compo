using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private SliderIrritate sliderIrritate;
    private SceneLoader sceneLoader;
    private DataController dataController;
    public RoundData roundData;
    private FreeSpaceController freeSpaceController;
    private Branch0 branch0Poll;
    private Branch1 branch1Poll;
    private Branch2 branch2Poll;
    private Branch3 branch3Poll;
    private Branch4 branch4Poll;
    private Branch5 branch5Poll;
    private Branch6 branch6Poll;
    private Branch7 branch7Poll;
    private Branch8 branch8Poll;
    private Branch9 branch9Poll;
    private Branch10 branch10Poll;
    private Branch11 branch11Poll;
    private Branch12 branch12Poll;
    private Branch13 branch13Poll;
    private Branch14 branch14Poll;
    private Branch15 branch15Poll;
    private Branch16 branch16Poll;
    private Branch17 branch17Poll;
    private Branch18 branch18Poll;
    private Branch19 branch19Poll;
    public float irritate;
    public float distractIrritate;
    public float iri = 0;
    public float iri2 = 0;
    public float iri3 = 0;
    public float iri4 = 0;
    public float iri5 = 0;
    public float iri6 = 0;
    public float iri7 = 0;
    public float iri8 = 0;
    public float iri9 = 0;
    public float iri10 = 0;
    public float iri11 = 0;
    public float iri12 = 0;
    public float iri13 = 0;
    public float iri14 = 0;
    public float iri15 = 0;
    public float iri16 = 0;
    public float iri17 = 0;
    public float iri18 = 0;
    public float iri19 = 0;
    private int n0 = 0;
    private int n1 = 0;
    private int n2 = 0;
    private int n3 = 0;
    private int n4 = 0;
    private int n5 = 0;
    private int n6 = 0;
    private int n7 = 0;
    private int n8 = 0;
    private int n9 = 0;
    private int n10 = 0;
    private int n11 = 0;
    private int n12 = 0;
    private int n13 = 0;
    private int n14 = 0;
    private int n15 = 0;
    private int n16 = 0;
    private int n17 = 0;
    private int n18 = 0;
    private int n19 = 0;
    private float timeRemaining;
    private float timeRemainingStart;
    public int questionIndex;
    private int roundNumber;

    private bool isDead = false;
    public int branchNumber = 0;


    // numbers for answers and ability
    public GameObject folderPrefab;
    public GameObject ownText;
    public GameObject[] folderPlace;

    public void PreviousFolder()
    {
        branchNumber -= 1;
    }
    public void NextFolder(int nNumber)
    {
        branchNumber += 1;
        if (branchNumber == 0)
        {
            //n0 = nNumber;
            ///  branch0Poll = roundData.foldersPerRound[n0];
        }
        if (branchNumber == 1)
        {
            n0 = nNumber;
            branch0Poll = roundData.foldersPerRound[n0];
        }
        if (branchNumber == 2)
        {
            n1 = nNumber;
            branch1Poll = branch0Poll.branch1[n1];
        }
        if (branchNumber == 3)
        {
            n2 = nNumber;
            branch2Poll = branch1Poll.branch2[n2];
        }
        if (branchNumber == 4)
        {
            n3 = nNumber;
            branch3Poll = branch2Poll.branch3[n3];
        }
        if (branchNumber == 5)
        {
            n4 = nNumber;
            branch4Poll = branch3Poll.branch4[n4];
        }
        if (branchNumber == 6)
        {
            n5 = nNumber;
            branch5Poll = branch4Poll.branch5[n5];
        }
        if (branchNumber == 7)
        {
            n6 = nNumber;
            branch6Poll = branch5Poll.branch6[n6];
        }
        if (branchNumber == 8)
        {
            n7 = nNumber;
            branch7Poll = branch6Poll.branch7[n7];
        }
        if (branchNumber == 9)
        {
            n8 = nNumber;
            branch8Poll = branch7Poll.branch8[n8];
        }
        if (branchNumber == 10)
        {
            n9 = nNumber;
            branch9Poll = branch8Poll.branch9[n9];
        }
        if (branchNumber == 11)
        {
            n10 = nNumber;
            branch10Poll = branch9Poll.branch10[n10];
        }
        if (branchNumber == 12)
        {
            n11 = nNumber;
            branch11Poll = branch10Poll.branch11[n11];
        }
        if (branchNumber == 13)
        {
            n12 = nNumber;
            branch12Poll = branch11Poll.branch12[n12];
        }
        if (branchNumber == 14)
        {
            n13 = nNumber;
            branch13Poll = branch12Poll.branch13[n13];
        }
        if (branchNumber == 15)
        {
            n14 = nNumber;
            branch14Poll = branch13Poll.branch14[n14];
        }
        if (branchNumber == 16)
        {
            n15 = nNumber;
            branch15Poll = branch14Poll.branch15[n15];
        }
        if (branchNumber == 17)
        {
            n16 = nNumber;
            branch16Poll = branch15Poll.branch16[n16];
        }
        if (branchNumber == 18)
        {
            n17 = nNumber;
            branch17Poll = branch16Poll.branch17[n17];
        }
        if (branchNumber == 19)
        {
            n18 = nNumber;
            branch18Poll = branch17Poll.branch18[n18];
        }



        /*
        branch0Poll = roundData.foldersPerRound[n0];
        branch1Poll = branch0Poll.branch1[n1];
        branch2Poll = branch1Poll.branch2[n2];
        branch3Poll = branch2Poll.branch3[n3];
        branch4Poll = branch3Poll.branch4[n4];
        branch5Poll = branch4Poll.branch5[n5];
        branch6Poll = branch5Poll.branch6[n6];
        branch7Poll = branch6Poll.branch7[n7];
        branch8Poll = branch7Poll.branch8[n8];
        branch9Poll = branch8Poll.branch9[n9];
        branch10Poll = branch9Poll.branch10[n10];
        branch11Poll = branch10Poll.branch11[n11];
        branch12Poll = branch11Poll.branch12[n12];
        branch13Poll = branch12Poll.branch13[n13];
        branch14Poll = branch13Poll.branch14[n14];
        branch15Poll = branch14Poll.branch15[n15];
        branch16Poll = branch15Poll.branch16[n16];
        branch17Poll = branch16Poll.branch17[n17];
        branch18Poll = branch17Poll.branch18[n18];
        branch19Poll = branch18Poll.branch19[n19];
        */

    }

    public void CountIrritate(int numb)
    {
        if (branchNumber == 0)
        {
            n0 = numb;
            branch0Poll = roundData.foldersPerRound[n0];
            float z = IriB1() * 4;
            distractIrritate = (roundData.foldersPerRound[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
            //odejmij all od licznika

        }
        if (branchNumber == 1)
        {
            n1 = numb;
            branch1Poll = branch0Poll.branch1[n1];
            float z = IriB2() * 4;
            distractIrritate = (branch0Poll.branch1[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 2)
        {
            n2 = numb;
            branch2Poll = branch1Poll.branch2[n2];
            float z = IriB3() * 4;
            distractIrritate = (branch1Poll.branch2[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 3)
        {
            n3 = numb;
            branch3Poll = branch2Poll.branch3[n3];
            float z = IriB4() * 4;
            distractIrritate = (branch2Poll.branch3[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 4)
        {
            n4 = numb;
            branch4Poll = branch3Poll.branch4[n4];
            float z = IriB5() * 4;
            distractIrritate = (branch3Poll.branch4[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 5)
        {
            n5 = numb;
            branch5Poll = branch4Poll.branch5[n5];
            float z = IriB6() * 4;
            distractIrritate = (branch4Poll.branch5[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 6)
        {
            n6 = numb;
            branch6Poll = branch5Poll.branch6[n6];
            float z = IriB7() * 4;
            distractIrritate = (branch5Poll.branch6[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 7)
        {
            n7 = numb;
            branch7Poll = branch6Poll.branch7[n7];
            float z = IriB8() * 4;
            distractIrritate = (branch6Poll.branch7[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 8)
        {
            n8 = numb;
            branch8Poll = branch7Poll.branch8[n8];
            float z = IriB9() * 4;
            distractIrritate = (branch7Poll.branch8[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 9)
        {
            n9 = numb;
            branch9Poll = branch8Poll.branch9[n9];
            float z = IriB10() * 4;
            distractIrritate = (branch8Poll.branch9[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 10)
        {
            n10 = numb;
            branch10Poll = branch9Poll.branch10[n10];
            float z = IriB11() * 4;
            distractIrritate = (branch9Poll.branch10[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 11)
        {
            n11 = numb;
            branch11Poll = branch10Poll.branch11[n11];
            float z = IriB12() * 4;
            distractIrritate = (branch10Poll.branch11[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 12)
        {
            n12 = numb;
            branch12Poll = branch11Poll.branch12[n12];
            float z = IriB13() * 4;
            distractIrritate = (branch11Poll.branch12[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 13)
        {
            n13 = numb;
            branch13Poll = branch12Poll.branch13[n13];
            float z = IriB14() * 4;
            distractIrritate = (branch12Poll.branch13[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 14)
        {
            n14 = numb;
            branch14Poll = branch13Poll.branch14[n14];
            float z = IriB15() * 4;
            distractIrritate = (branch13Poll.branch14[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 15)
        {
            n15 = numb;
            branch15Poll = branch14Poll.branch15[n15];
            float z = IriB16() * 4;
            distractIrritate = (branch14Poll.branch15[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 16)
        {
            n16 = numb;
            branch16Poll = branch15Poll.branch16[n16];
            float z = IriB17() * 4;
            distractIrritate = (branch15Poll.branch16[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 17)
        {
            n17 = numb;
            branch17Poll = branch16Poll.branch17[n17];
            float z = IriB18() * 4;
            distractIrritate = (branch16Poll.branch17[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 18)
        {
            n18 = numb;
            branch18Poll = branch17Poll.branch18[n18];
            float z = IriB19() * 4;
            distractIrritate = (branch17Poll.branch18[numb].irritate) + z;
            sliderIrritate.IrritateHim(distractIrritate);
        }
        if (branchNumber == 19)
        {
            n19 = numb;
            branch19Poll = branch18Poll.branch19[n19];
            distractIrritate = (branch18Poll.branch19[numb].irritate);
            sliderIrritate.IrritateHim(distractIrritate);
        }
    }


    public float IriB1()
    {
        for (int d = 0; d < roundData.foldersPerRound[n0].branch1.Length; d++)
        {
            iri += roundData.foldersPerRound[n0].branch1[d].irritate
                /
                roundData.foldersPerRound[n0].branch1.Length;
            print("b1 iri is " + iri);

            for (int e = 0; e < roundData.foldersPerRound[n0].branch1[d].branch2.Length; e++)
            {
                iri2 += roundData.foldersPerRound[n0].branch1[d].branch2[e].irritate
                    /
                    roundData.foldersPerRound[n0].branch1.Length;
                print("b2 iri is " + iri2);

                for (int f = 0; f < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3.Length; f++)
                {
                    iri3 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].irritate
                        /
                        roundData.foldersPerRound[n0].branch1.Length;
                    print("b3 iri is " + iri3);
                    for (int g = 0; g < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4.Length; g++)
                    {
                        iri4 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].irritate
                            /
                            roundData.foldersPerRound[n0].branch1.Length;
                        print("b4 iri is " + iri4);
                        for (int h = 0; h < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5.Length; h++)
                        {
                            iri5 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].irritate
                                /
                                roundData.foldersPerRound[n0].branch1.Length;
                            print("b5 iri is " + iri5);
                            for (int i = 0; i < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6.Length; i++)
                            {
                                iri6 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int j = 0; j < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7.Length; j++)
                                {
                                    iri7 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int k = 0; k < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                        .branch8.Length; k++)
                                    {
                                        iri8 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                            branch8[k].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int l = 0; l < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                        .branch8[k].branch9.Length; l++)
                                        {
                                            iri9 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                branch8[k].branch9[l].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                            for (int m = 0; m < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                            .branch8[k].branch9[l].branch10.Length; m++)
                                            {
                                                iri10 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                    branch8[k].branch9[l].branch10[m].irritate
                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                for (int n = 0; n < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                .branch8[k].branch9[l].branch10[m].branch11.Length; n++)
                                                {
                                                    iri11 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                        branch8[k].branch9[l].branch10[m].branch11[n].irritate
                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                    for (int o = 0; o < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12.Length; o++)
                                                    {
                                                        iri12 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].irritate
                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                        for (int p = 0; p < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13.Length; p++)
                                                        {
                                                            iri13 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].irritate
                                                                / roundData.foldersPerRound[n0].branch1.Length;
                                                            for (int r = 0; r < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                                                            {
                                                                iri14 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                                for (int s = 0; s < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                                                                {
                                                                    iri15 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                                    for (int t = 0; t < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                    branch16.Length; t++)
                                                                    {
                                                                        iri16 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                            branch15[s].branch16[t].irritate
                                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                                        for (int u = 0; u < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                            branch16[t].branch17.Length; u++)
                                                                        {
                                                                            iri17 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                                branch15[s].branch16[t].branch17[u].irritate
                                                                                / roundData.foldersPerRound[n0].branch1.Length;
                                                                            for (int w = 0; w < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                            branch16[t].branch17[u].branch18.Length; w++)
                                                                            {
                                                                                iri18 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                                    branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                                                for (int y = 0; y < roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                                branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                                                                {
                                                                                    iri19 += roundData.foldersPerRound[n0].branch1[d].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                                        branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        return iri + iri2 + iri3 + iri4 + iri5 + iri6 + iri7 + iri8 + iri9 + iri10 + iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB2()
    {
        for (int e = 0; e < roundData.foldersPerRound[n0].branch1[n1].branch2.Length; e++)
        {
            iri2 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].irritate
                /
                roundData.foldersPerRound[n0].branch1.Length;
            print("b2 iri is " + iri2);

            for (int f = 0; f < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3.Length; f++)
            {
                iri3 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].irritate
                    /
                    roundData.foldersPerRound[n0].branch1.Length;
                print("b3 iri is " + iri3);
                for (int g = 0; g < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4.Length; g++)
                {
                    iri4 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].irritate
                        /
                        roundData.foldersPerRound[n0].branch1.Length;
                    print("b4 iri is " + iri4);
                    for (int h = 0; h < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5.Length; h++)
                    {
                        iri5 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].irritate
                            /
                            roundData.foldersPerRound[n0].branch1.Length;
                        print("b5 iri is " + iri5);
                        for (int i = 0; i < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6.Length; i++)
                        {
                            iri6 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int j = 0; j < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7.Length; j++)
                            {
                                iri7 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int k = 0; k < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                    .branch8.Length; k++)
                                {
                                    iri8 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                        branch8[k].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int l = 0; l < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                    .branch8[k].branch9.Length; l++)
                                    {
                                        iri9 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                            branch8[k].branch9[l].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int m = 0; m < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                        .branch8[k].branch9[l].branch10.Length; m++)
                                        {
                                            iri10 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                branch8[k].branch9[l].branch10[m].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                            for (int n = 0; n < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                            .branch8[k].branch9[l].branch10[m].branch11.Length; n++)
                                            {
                                                iri11 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                    branch8[k].branch9[l].branch10[m].branch11[n].irritate
                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12.Length; o++)
                                                {
                                                    iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].irritate
                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                    for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13.Length; p++)
                                                    {
                                                        iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].irritate
                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                        for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                                                        {
                                                            iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                                                                / roundData.foldersPerRound[n0].branch1.Length;
                                                            for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                                                            {
                                                                iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                                for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                branch16.Length; t++)
                                                                {
                                                                    iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                        branch15[s].branch16[t].irritate
                                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                                    for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                        branch16[t].branch17.Length; u++)
                                                                    {
                                                                        iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                            branch15[s].branch16[t].branch17[u].irritate
                                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                                        for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                        branch16[t].branch17[u].branch18.Length; w++)
                                                                        {
                                                                            iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                                branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                                                                / roundData.foldersPerRound[n0].branch1.Length;
                                                                            for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                            branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                                                            {
                                                                                iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[e].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                                    branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        return iri2 + iri3 + iri4 + iri5 + iri6 + iri7 + iri8 + iri9 + iri10 + iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB3()
    {
        for (int f = 0; f < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3.Length; f++)
        {
            iri3 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].irritate
                /
                roundData.foldersPerRound[n0].branch1.Length;
            print("b3 iri is " + iri3);
            for (int g = 0; g < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4.Length; g++)
            {
                iri4 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].irritate
                    /
                    roundData.foldersPerRound[n0].branch1.Length;
                print("b4 iri is " + iri4);
                for (int h = 0; h < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5.Length; h++)
                {
                    iri5 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].irritate
                        /
                        roundData.foldersPerRound[n0].branch1.Length;
                    print("b5 iri is " + iri5);
                    for (int i = 0; i < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6.Length; i++)
                    {
                        iri6 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int j = 0; j < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7.Length; j++)
                        {
                            iri7 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int k = 0; k < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                .branch8.Length; k++)
                            {
                                iri8 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                    branch8[k].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int l = 0; l < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                .branch8[k].branch9.Length; l++)
                                {
                                    iri9 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                        branch8[k].branch9[l].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int m = 0; m < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                    .branch8[k].branch9[l].branch10.Length; m++)
                                    {
                                        iri10 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                            branch8[k].branch9[l].branch10[m].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int n = 0; n < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                        .branch8[k].branch9[l].branch10[m].branch11.Length; n++)
                                        {
                                            iri11 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                branch8[k].branch9[l].branch10[m].branch11[n].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                            for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12.Length; o++)
                                            {
                                                iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].irritate
                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13.Length; p++)
                                                {
                                                    iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].irritate
                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                    for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                                                    {
                                                        iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                        for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                                                        {
                                                            iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                                                / roundData.foldersPerRound[n0].branch1.Length;
                                                            for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                            branch16.Length; t++)
                                                            {
                                                                iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                    branch15[s].branch16[t].irritate
                                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                                for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                    branch16[t].branch17.Length; u++)
                                                                {
                                                                    iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                        branch15[s].branch16[t].branch17[u].irritate
                                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                                    for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                    branch16[t].branch17[u].branch18.Length; w++)
                                                                    {
                                                                        iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                            branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                                        for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                        branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                                                        {
                                                                            iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[f].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                                branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                                                / roundData.foldersPerRound[n0].branch1.Length;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }
        return iri3 + iri4 + iri5 + iri6 + iri7 + iri8 + iri9 + iri10 + iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB4()
    {
        for (int g = 0; g < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4.Length; g++)
        {
            iri4 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].irritate
                /
                roundData.foldersPerRound[n0].branch1.Length;
            print("b4 iri is " + iri4);
            for (int h = 0; h < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5.Length; h++)
            {
                iri5 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].irritate
                    /
                    roundData.foldersPerRound[n0].branch1.Length;
                print("b5 iri is " + iri5);
                for (int i = 0; i < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6.Length; i++)
                {
                    iri6 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int j = 0; j < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7.Length; j++)
                    {
                        iri7 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int k = 0; k < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                            .branch8.Length; k++)
                        {
                            iri8 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                branch8[k].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int l = 0; l < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                            .branch8[k].branch9.Length; l++)
                            {
                                iri9 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                    branch8[k].branch9[l].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int m = 0; m < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                                .branch8[k].branch9[l].branch10.Length; m++)
                                {
                                    iri10 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                        branch8[k].branch9[l].branch10[m].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int n = 0; n < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                                    .branch8[k].branch9[l].branch10[m].branch11.Length; n++)
                                    {
                                        iri11 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                            branch8[k].branch9[l].branch10[m].branch11[n].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12.Length; o++)
                                        {
                                            iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                            for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13.Length; p++)
                                            {
                                                iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].irritate
                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                                                {
                                                    iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                    for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                                                    {
                                                        iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                        for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                        branch16.Length; t++)
                                                        {
                                                            iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                branch15[s].branch16[t].irritate
                                                                / roundData.foldersPerRound[n0].branch1.Length;
                                                            for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                branch16[t].branch17.Length; u++)
                                                            {
                                                                iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                    branch15[s].branch16[t].branch17[u].irritate
                                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                                for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                branch16[t].branch17[u].branch18.Length; w++)
                                                                {
                                                                    iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                        branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                                    for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j]
                                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                    branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                                                    {
                                                                        iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[g].branch5[h].branch6[i].branch7[j].
                                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                            branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }



        }
        return iri4 + iri5 + iri6 + iri7 + iri8 + iri9 + iri10 + iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB5()
    {
        for (int h = 0; h < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5.Length; h++)
        {
            iri5 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].irritate
                /
                roundData.foldersPerRound[n0].branch1.Length;
            print("b5 iri is " + iri5);
            for (int i = 0; i < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6.Length; i++)
            {
                iri6 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int j = 0; j < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7.Length; j++)
                {
                    iri7 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int k = 0; k < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                        .branch8.Length; k++)
                    {
                        iri8 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                            branch8[k].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int l = 0; l < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                        .branch8[k].branch9.Length; l++)
                        {
                            iri9 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                branch8[k].branch9[l].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int m = 0; m < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                            .branch8[k].branch9[l].branch10.Length; m++)
                            {
                                iri10 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                    branch8[k].branch9[l].branch10[m].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int n = 0; n < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                                .branch8[k].branch9[l].branch10[m].branch11.Length; n++)
                                {
                                    iri11 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                        branch8[k].branch9[l].branch10[m].branch11[n].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12.Length; o++)
                                    {
                                        iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13.Length; p++)
                                        {
                                            iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                            for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                                            {
                                                iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                                                {
                                                    iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                    for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                    branch16.Length; t++)
                                                    {
                                                        iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                            branch15[s].branch16[t].irritate
                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                        for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                            branch16[t].branch17.Length; u++)
                                                        {
                                                            iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                branch15[s].branch16[t].branch17[u].irritate
                                                                / roundData.foldersPerRound[n0].branch1.Length;
                                                            for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                            branch16[t].branch17[u].branch18.Length; w++)
                                                            {
                                                                iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                    branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                                for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j]
                                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                                branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                                                {
                                                                    iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[h].branch6[i].branch7[j].
                                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                        branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }




        }
        return iri5 + iri6 + iri7 + iri8 + iri9 + iri10 + iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB6()
    {
        for (int i = 0; i < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6.Length; i++)
        {
            iri6 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int j = 0; j < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7.Length; j++)
            {
                iri7 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int k = 0; k < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                    .branch8.Length; k++)
                {
                    iri8 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                        branch8[k].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int l = 0; l < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                    .branch8[k].branch9.Length; l++)
                    {
                        iri9 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                            branch8[k].branch9[l].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int m = 0; m < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                        .branch8[k].branch9[l].branch10.Length; m++)
                        {
                            iri10 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                                branch8[k].branch9[l].branch10[m].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int n = 0; n < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                            .branch8[k].branch9[l].branch10[m].branch11.Length; n++)
                            {
                                iri11 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                                    branch8[k].branch9[l].branch10[m].branch11[n].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12.Length; o++)
                                {
                                    iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13.Length; p++)
                                    {
                                        iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                                        {
                                            iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                            for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                                            {
                                                iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                branch16.Length; t++)
                                                {
                                                    iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                        branch15[s].branch16[t].irritate
                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                    for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                        branch16[t].branch17.Length; u++)
                                                    {
                                                        iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                            branch15[s].branch16[t].branch17[u].irritate
                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                        for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                        branch16[t].branch17[u].branch18.Length; w++)
                                                        {
                                                            iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                                                / roundData.foldersPerRound[n0].branch1.Length;
                                                            for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j]
                                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                            branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                                            {
                                                                iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[i].branch7[j].
                                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                    branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        return iri6 + iri7 + iri8 + iri9 + iri10 + iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB7()
    {
        for (int j = 0; j < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7.Length; j++)
        {
            iri7 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int k = 0; k < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                .branch8.Length; k++)
            {
                iri8 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                    branch8[k].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int l = 0; l < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                .branch8[k].branch9.Length; l++)
                {
                    iri9 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                        branch8[k].branch9[l].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int m = 0; m < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                    .branch8[k].branch9[l].branch10.Length; m++)
                    {
                        iri10 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                            branch8[k].branch9[l].branch10[m].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int n = 0; n < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                        .branch8[k].branch9[l].branch10[m].branch11.Length; n++)
                        {
                            iri11 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                                branch8[k].branch9[l].branch10[m].branch11[n].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12.Length; o++)
                            {
                                iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13.Length; p++)
                                {
                                    iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                                    {
                                        iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                                        {
                                            iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                            for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                            branch16.Length; t++)
                                            {
                                                iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                    branch15[s].branch16[t].irritate
                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                    branch16[t].branch17.Length; u++)
                                                {
                                                    iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                        branch15[s].branch16[t].branch17[u].irritate
                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                    for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                    branch16[t].branch17[u].branch18.Length; w++)
                                                    {
                                                        iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                            branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                        for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j]
                                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                        branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                                        {
                                                            iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[j].
                                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                                branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                                / roundData.foldersPerRound[n0].branch1.Length;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }
        return iri7 + iri8 + iri9 + iri10 + iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB8()
    {
        for (int k = 0; k < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8.Length; k++)
        {
            iri8 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[k].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int l = 0; l < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[k].branch9.Length; l++)
            {
                iri9 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[k].branch9[l].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int m = 0; m < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                .branch8[k].branch9[l].branch10.Length; m++)
                {
                    iri10 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                        branch8[k].branch9[l].branch10[m].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int n = 0; n < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                    .branch8[k].branch9[l].branch10[m].branch11.Length; n++)
                    {
                        iri11 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                            branch8[k].branch9[l].branch10[m].branch11[n].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12.Length; o++)
                        {
                            iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13.Length; p++)
                            {
                                iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                                {
                                    iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                                    {
                                        iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                        .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                        branch16.Length; t++)
                                        {
                                            iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                                branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                branch15[s].branch16[t].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                            for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                            .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                branch16[t].branch17.Length; u++)
                                            {
                                                iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                                    branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                    branch15[s].branch16[t].branch17[u].irritate
                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                                .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                branch16[t].branch17[u].branch18.Length; w++)
                                                {
                                                    iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                                        branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                        branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                    for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                                    .branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                    branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                                    {
                                                        iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                                            branch8[k].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                            branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                            / roundData.foldersPerRound[n0].branch1.Length;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }
        return iri8 + iri9 + iri10 + iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB9()
    {
        for (int l = 0; l < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9.Length; l++)
        {
            iri9 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[l].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int m = 0; m < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[n8].branch9[l].branch10.Length; m++)
            {
                iri10 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[n8].branch9[l].branch10[m].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int n = 0; n < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                .branch8[n8].branch9[l].branch10[m].branch11.Length; n++)
                {
                    iri11 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                        branch8[n8].branch9[l].branch10[m].branch11[n].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                    .branch8[n8].branch9[l].branch10[m].branch11[n].branch12.Length; o++)
                    {
                        iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                            branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                        .branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13.Length; p++)
                        {
                            iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                            .branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                            {
                                iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                    branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                .branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                                {
                                    iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                        branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                    .branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                    branch16.Length; t++)
                                    {
                                        iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                            branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                            branch15[s].branch16[t].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                        .branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                            branch16[t].branch17.Length; u++)
                                        {
                                            iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                                branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                branch15[s].branch16[t].branch17[u].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                            for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                            .branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                            branch16[t].branch17[u].branch18.Length; w++)
                                            {
                                                iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                                    branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                    branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                                for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                                .branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                                branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                                {
                                                    iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                                        branch8[n8].branch9[l].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                        branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                        / roundData.foldersPerRound[n0].branch1.Length;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        return iri9 + iri10 + iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB10()
    {
        for (int m = 0; m < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9[n9].branch10.Length; m++)
        {
            iri10 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[n9].branch10[m].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int n = 0; n < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[n8].branch9[n9].branch10[m].branch11.Length; n++)
            {
                iri11 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[n8].branch9[n9].branch10[m].branch11[n].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                .branch8[n8].branch9[n9].branch10[m].branch11[n].branch12.Length; o++)
                {
                    iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                        branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                    .branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13.Length; p++)
                    {
                        iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                            branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                        .branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                        {
                            iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                            .branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                            {
                                iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                    branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                .branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                branch16.Length; t++)
                                {
                                    iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                        branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                        branch15[s].branch16[t].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                    .branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                        branch16[t].branch17.Length; u++)
                                    {
                                        iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                            branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                            branch15[s].branch16[t].branch17[u].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                        .branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                        branch16[t].branch17[u].branch18.Length; w++)
                                        {
                                            iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                                branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                            for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                            .branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                            branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                            {
                                                iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                                    branch8[n8].branch9[n9].branch10[m].branch11[n].branch12[o].branch13[p].branch14[r].
                                                    branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                    / roundData.foldersPerRound[n0].branch1.Length;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        return iri10 + iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB11()
    {
        for (int n = 0; n < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9[n9].branch10[n10].branch11.Length; n++)
        {
            iri11 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[n9].branch10[n10].branch11[n].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12.Length; o++)
            {
                iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                .branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13.Length; p++)
                {
                    iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                        branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                    .branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14.Length; r++)
                    {
                        iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                            branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                        .branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                        {
                            iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                            .branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                            branch16.Length; t++)
                            {
                                iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                    branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].
                                    branch15[s].branch16[t].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                .branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                    branch16[t].branch17.Length; u++)
                                {
                                    iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                        branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].
                                        branch15[s].branch16[t].branch17[u].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                    .branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                    branch16[t].branch17[u].branch18.Length; w++)
                                    {
                                        iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                            branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].
                                            branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                        for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                        .branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].branch15[s].
                                        branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                        {
                                            iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                                branch8[n8].branch9[n9].branch10[n10].branch11[n].branch12[o].branch13[p].branch14[r].
                                                branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                                / roundData.foldersPerRound[n0].branch1.Length;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        return iri11 + iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB12()
    {
        for (int o = 0; o < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12.Length; o++)
        {
            iri12 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13.Length; p++)
            {
                iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14.Length; r++)
                {
                    iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                        branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                    .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].branch15.Length; s++)
                    {
                        iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                            branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].branch15[s].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].branch15[s].
                        branch16.Length; t++)
                        {
                            iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].
                                branch15[s].branch16[t].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                            .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].branch15[s].
                                branch16[t].branch17.Length; u++)
                            {
                                iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                    branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].
                                    branch15[s].branch16[t].branch17[u].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].branch15[s].
                                branch16[t].branch17[u].branch18.Length; w++)
                                {
                                    iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                        branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].
                                        branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                    for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                    .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].branch15[s].
                                    branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                    {
                                        iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                            branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[o].branch13[p].branch14[r].
                                            branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                            / roundData.foldersPerRound[n0].branch1.Length;
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        return iri12 + iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB13()
    {
        for (int p = 0; p < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13.Length; p++)
        {
            iri13 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14.Length; r++)
            {
                iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].branch15.Length; s++)
                {
                    iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                        branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].branch15[s].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                    .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].branch15[s].
                    branch16.Length; t++)
                    {
                        iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                            branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].
                            branch15[s].branch16[t].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].branch15[s].
                            branch16[t].branch17.Length; u++)
                        {
                            iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].
                                branch15[s].branch16[t].branch17[u].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                            .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].branch15[s].
                            branch16[t].branch17[u].branch18.Length; w++)
                            {
                                iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                    branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].
                                    branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                                for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                                .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].branch15[s].
                                branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                                {
                                    iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                        branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[p].branch14[r].
                                        branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                        / roundData.foldersPerRound[n0].branch1.Length;
                                }
                            }
                        }
                    }
                }
            }

        }
        return iri13 + iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB14()
    {
        for (int r = 0; r < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14.Length; r++)
        {
            iri14 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].branch15.Length; s++)
            {
                iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].branch15[s].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].branch15[s].
                branch16.Length; t++)
                {
                    iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                        branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].
                        branch15[s].branch16[t].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                    .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].branch15[s].
                        branch16[t].branch17.Length; u++)
                    {
                        iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                            branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].
                            branch15[s].branch16[t].branch17[u].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].branch15[s].
                        branch16[t].branch17[u].branch18.Length; w++)
                        {
                            iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].
                                branch15[s].branch16[t].branch17[u].branch18[w].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                            for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                            .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].branch15[s].
                            branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                            {
                                iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                    branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[r].
                                    branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                    / roundData.foldersPerRound[n0].branch1.Length;
                            }
                        }
                    }
                }
            }

        }
        return iri14 + iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB15()
    {
        for (int s = 0; s < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15.Length; s++)
        {
            iri15 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[s].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[s].
            branch16.Length; t++)
            {
                iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                    branch15[s].branch16[t].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[s].
                    branch16[t].branch17.Length; u++)
                {
                    iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                        branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                        branch15[s].branch16[t].branch17[u].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                    .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[s].
                    branch16[t].branch17[u].branch18.Length; w++)
                    {
                        iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                            branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                            branch15[s].branch16[t].branch17[u].branch18[w].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                        for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[s].
                        branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                        {
                            iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                                branch15[s].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                                / roundData.foldersPerRound[n0].branch1.Length;
                        }
                    }
                }
            }

        }
        return iri15 + iri16 + iri17 + iri18 + iri19;
    }
    public float IriB16()
    {
        for (int t = 0; t < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[n15].
        branch16.Length; t++)
        {
            iri16 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                branch15[n15].branch16[t].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[n15].
                branch16[t].branch17.Length; u++)
            {
                iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                    branch15[n15].branch16[t].branch17[u].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[n15].
                branch16[t].branch17[u].branch18.Length; w++)
                {
                    iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                        branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                        branch15[n15].branch16[t].branch17[u].branch18[w].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                    for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                    .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[n15].
                    branch16[t].branch17[u].branch18[w].branch19.Length; y++)
                    {
                        iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                            branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                            branch15[n15].branch16[t].branch17[u].branch18[w].branch19[y].irritate
                            / roundData.foldersPerRound[n0].branch1.Length;
                    }
                }
            }

        }
        return iri16 + iri17 + iri18 + iri19;
    }
    public float IriB17()
    {
        for (int u = 0; u < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[n15].
            branch16[n16].branch17.Length; u++)
        {
            iri17 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                branch15[n15].branch16[n16].branch17[u].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[n15].
            branch16[n16].branch17[u].branch18.Length; w++)
            {
                iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                    branch15[n15].branch16[n16].branch17[u].branch18[w].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
                for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
                .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[n15].
                branch16[n16].branch17[u].branch18[w].branch19.Length; y++)
                {
                    iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                        branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                        branch15[n15].branch16[n16].branch17[u].branch18[w].branch19[y].irritate
                        / roundData.foldersPerRound[n0].branch1.Length;
                }
            }

        }
        return iri17 + iri18 + iri19;
    }
    public float IriB18()
    {

        for (int w = 0; w < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[n15].
        branch16[n16].branch17[n17].branch18.Length; w++)
        {
            iri18 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                branch15[n15].branch16[n16].branch17[n17].branch18[w].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
            for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
            .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[n15].
            branch16[n16].branch17[n17].branch18[w].branch19.Length; y++)
            {
                iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                    branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                    branch15[n15].branch16[n16].branch17[n17].branch18[w].branch19[y].irritate
                    / roundData.foldersPerRound[n0].branch1.Length;
            }
        }


        return iri18 + iri19;
    }
    public float IriB19()
    {

        for (int y = 0; y < roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7]
        .branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].branch15[n15].
        branch16[n16].branch17[n17].branch18[n18].branch19.Length; y++)
        {
            iri19 += roundData.foldersPerRound[n0].branch1[n1].branch2[n2].branch3[n3].branch4[n4].branch5[n5].branch6[n6].branch7[n7].
                branch8[n8].branch9[n9].branch10[n10].branch11[n11].branch12[n12].branch13[n13].branch14[n14].
                branch15[n15].branch16[n16].branch17[n17].branch18[n18].branch19[y].irritate
                / roundData.foldersPerRound[n0].branch1.Length;
        }


        return iri19;
    }


    public void ClearArray(int numbo)
    {
        if (branchNumber == 0)
        {
            for (int a = numbo; a < roundData.foldersPerRound.Length - 1; a++)
            {
                roundData.foldersPerRound[a] = roundData.foldersPerRound[a + 1];
            }
            System.Array.Resize(ref roundData.foldersPerRound, roundData.foldersPerRound.Length - 1);
            //roundData.foldersPerRound[roundData.foldersPerRound.Length - 1] = null;

            //roundData.foldersPerRound[roundData.foldersPerRound.Length - 1].irritate = 0f;
            NewSetOfFolders();
        }
        if (branchNumber == 1)
        {
            print("legth" + branch0Poll.branch1.Length);
            for (int a = numbo; a < branch0Poll.branch1.Length - 1; a++)
            {
                branch0Poll.branch1[a] = branch0Poll.branch1[a + 1];
            }
            System.Array.Resize(ref branch0Poll.branch1, branch0Poll.branch1.Length - 1);
            print("new legth" + branch0Poll.branch1.Length);
            //branch0Poll.branch1[branch0Poll.branch1.Length - 1] = null;
            //branch0Poll.branch1[branch0Poll.branch1.Length - 1].irritate = 0f;
            NewSetOfFolders();

        }
        if (branchNumber == 2)
        {
            for (int a = numbo; a < branch1Poll.branch2.Length - 1; a++)
            {
                branch1Poll.branch2[a] = branch1Poll.branch2[a + 1];
            }
            System.Array.Resize(ref branch1Poll.branch2, branch1Poll.branch2.Length - 1);
            //branch1Poll.branch2[branch1Poll.branch2.Length - 1] = null;
            //branch1Poll.branch2[branch1Poll.branch2.Length - 1].irritate = 0f;
            NewSetOfFolders();
        }
        if (branchNumber == 3)
        {
            for (int a = numbo; a < branch2Poll.branch3.Length - 1; a++)
            {
                branch2Poll.branch3[a] = branch2Poll.branch3[a + 1];
            }
            System.Array.Resize(ref branch2Poll.branch3, branch2Poll.branch3.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 4)
        {
            for (int a = numbo; a < branch3Poll.branch4.Length - 1; a++)
            {
                branch3Poll.branch4[a] = branch3Poll.branch4[a + 1];
            }
            System.Array.Resize(ref branch3Poll.branch4, branch3Poll.branch4.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 5)
        {
            for (int a = numbo; a < branch4Poll.branch5.Length - 1; a++)
            {
                branch4Poll.branch5[a] = branch4Poll.branch5[a + 1];
            }
            System.Array.Resize(ref branch4Poll.branch5, branch4Poll.branch5.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 6)
        {
            for (int a = numbo; a < branch5Poll.branch6.Length - 1; a++)
            {
                branch5Poll.branch6[a] = branch5Poll.branch6[a + 1];
            }
            System.Array.Resize(ref branch5Poll.branch6, branch5Poll.branch6.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 7)
        {
            for (int a = numbo; a < branch6Poll.branch7.Length - 1; a++)
            {
                branch6Poll.branch7[a] = branch6Poll.branch7[a + 1];
            }
            System.Array.Resize(ref branch6Poll.branch7, branch6Poll.branch7.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 8)
        {
            for (int a = numbo; a < branch7Poll.branch8.Length - 1; a++)
            {
                branch7Poll.branch8[a] = branch7Poll.branch8[a + 1];
            }
            System.Array.Resize(ref branch7Poll.branch8, branch7Poll.branch8.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 9)
        {
            for (int a = numbo; a < branch8Poll.branch9.Length - 1; a++)
            {
                branch8Poll.branch9[a] = branch8Poll.branch9[a + 1];
            }
            System.Array.Resize(ref branch8Poll.branch9, branch8Poll.branch9.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 10)
        {
            for (int a = numbo; a < branch9Poll.branch10.Length - 1; a++)
            {
                branch9Poll.branch10[a] = branch9Poll.branch10[a + 1];
            }
            System.Array.Resize(ref branch9Poll.branch10, branch9Poll.branch10.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 11)
        {
            for (int a = numbo; a < branch10Poll.branch11.Length - 1; a++)
            {
                branch10Poll.branch11[a] = branch10Poll.branch11[a + 1];
            }
            System.Array.Resize(ref branch10Poll.branch11, branch10Poll.branch11.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 12)
        {
            for (int a = numbo; a < branch11Poll.branch12.Length - 1; a++)
            {
                branch11Poll.branch12[a] = branch11Poll.branch12[a + 1];
            }
            System.Array.Resize(ref branch11Poll.branch12, branch11Poll.branch12.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 13)
        {
            for (int a = numbo; a < branch12Poll.branch13.Length - 1; a++)
            {
                branch12Poll.branch13[a] = branch12Poll.branch13[a + 1];
            }
            System.Array.Resize(ref branch12Poll.branch13, branch12Poll.branch13.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 14)
        {
            for (int a = numbo; a < branch13Poll.branch14.Length - 1; a++)
            {
                branch13Poll.branch14[a] = branch13Poll.branch14[a + 1];
            }
            System.Array.Resize(ref branch13Poll.branch14, branch13Poll.branch14.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 15)
        {
            for (int a = numbo; a < branch14Poll.branch15.Length - 1; a++)
            {
                branch14Poll.branch15[a] = branch14Poll.branch15[a + 1];
            }
            System.Array.Resize(ref branch14Poll.branch15, branch14Poll.branch15.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 16)
        {
            for (int a = numbo; a < branch15Poll.branch16.Length - 1; a++)
            {
                branch15Poll.branch16[a] = branch15Poll.branch16[a + 1];
            }
            System.Array.Resize(ref branch15Poll.branch16, branch15Poll.branch16.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 17)
        {
            for (int a = numbo; a < branch16Poll.branch17.Length - 1; a++)
            {
                branch16Poll.branch17[a] = branch16Poll.branch17[a + 1];
            }
            System.Array.Resize(ref branch16Poll.branch17, branch16Poll.branch17.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 18)
        {
            for (int a = numbo; a < branch17Poll.branch18.Length - 1; a++)
            {
                branch17Poll.branch18[a] = branch17Poll.branch18[a + 1];
            }
            System.Array.Resize(ref branch17Poll.branch18, branch17Poll.branch18.Length - 1);
            NewSetOfFolders();
        }
        if (branchNumber == 19)
        {
            for (int a = numbo; a < branch18Poll.branch19.Length - 1; a++)
            {
                branch18Poll.branch19[a] = branch18Poll.branch19[a + 1];
            }
            System.Array.Resize(ref branch18Poll.branch19, branch18Poll.branch19.Length - 1);
            NewSetOfFolders();
        }
    }




    public void NewSetOfFolders()
    {
        for (int n = 0; n < folderPlace.Length; n++)
        {
            foreach (Transform child in folderPlace[n].transform)
            {
                Destroy(child.gameObject);
            }
        }
        if (branchNumber == 0)
        {
            for (int b = 0; b < roundData.foldersPerRound.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = roundData.foldersPerRound[b].name;
                makethis.GetComponent<FolderObject>().size = roundData.foldersPerRound[b].size;
                makethis.GetComponent<FolderObject>().irritate = roundData.foldersPerRound[b].irritate;
                makethis.GetComponent<FolderObject>().gb = roundData.foldersPerRound[b].gb;
                makethis.GetComponent<FolderObject>().mb = roundData.foldersPerRound[b].mb;
                makethis.GetComponent<FolderObject>().b = roundData.foldersPerRound[b].b;
                makethis.GetComponent<FolderObject>().isFolder = roundData.foldersPerRound[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = roundData.foldersPerRound[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = roundData.foldersPerRound[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = roundData.foldersPerRound[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = roundData.foldersPerRound[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;

            }
        }
        if (branchNumber == 1)
        {
            for (int b = 0; b < branch0Poll.branch1.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch0Poll.branch1[b].name;
                makethis.GetComponent<FolderObject>().size = branch0Poll.branch1[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch0Poll.branch1[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch0Poll.branch1[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch0Poll.branch1[b].mb;
                makethis.GetComponent<FolderObject>().b = branch0Poll.branch1[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch0Poll.branch1[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch0Poll.branch1[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch0Poll.branch1[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch0Poll.branch1[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch0Poll.branch1[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 2)
        {
            for (int b = 0; b < branch1Poll.branch2.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch1Poll.branch2[b].name;
                makethis.GetComponent<FolderObject>().size = branch1Poll.branch2[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch1Poll.branch2[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch1Poll.branch2[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch1Poll.branch2[b].mb;
                makethis.GetComponent<FolderObject>().b = branch1Poll.branch2[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch1Poll.branch2[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch1Poll.branch2[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch1Poll.branch2[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch1Poll.branch2[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch1Poll.branch2[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 3)
        {
            for (int b = 0; b < branch2Poll.branch3.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch2Poll.branch3[b].name;
                makethis.GetComponent<FolderObject>().size = branch2Poll.branch3[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch2Poll.branch3[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch2Poll.branch3[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch2Poll.branch3[b].mb;
                makethis.GetComponent<FolderObject>().b = branch2Poll.branch3[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch2Poll.branch3[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch2Poll.branch3[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch2Poll.branch3[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch2Poll.branch3[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch2Poll.branch3[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;

            }
        }
        if (branchNumber == 4)
        {
            for (int b = 0; b < branch3Poll.branch4.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch3Poll.branch4[b].name;
                makethis.GetComponent<FolderObject>().size = branch3Poll.branch4[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch3Poll.branch4[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch3Poll.branch4[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch3Poll.branch4[b].mb;
                makethis.GetComponent<FolderObject>().b = branch3Poll.branch4[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch3Poll.branch4[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch3Poll.branch4[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch3Poll.branch4[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch3Poll.branch4[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch3Poll.branch4[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;

            }
        }
        if (branchNumber == 5)
        {
            for (int b = 0; b < branch4Poll.branch5.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch4Poll.branch5[b].name;
                makethis.GetComponent<FolderObject>().size = branch4Poll.branch5[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch4Poll.branch5[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch4Poll.branch5[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch4Poll.branch5[b].mb;
                makethis.GetComponent<FolderObject>().b = branch4Poll.branch5[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch4Poll.branch5[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch4Poll.branch5[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch4Poll.branch5[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch4Poll.branch5[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch4Poll.branch5[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;

            }
        }
        if (branchNumber == 6)
        {
            for (int b = 0; b < branch5Poll.branch6.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch5Poll.branch6[b].name;
                makethis.GetComponent<FolderObject>().size = branch5Poll.branch6[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch5Poll.branch6[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch5Poll.branch6[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch5Poll.branch6[b].mb;
                makethis.GetComponent<FolderObject>().b = branch5Poll.branch6[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch5Poll.branch6[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch5Poll.branch6[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch5Poll.branch6[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch5Poll.branch6[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch5Poll.branch6[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 7)
        {
            for (int b = 0; b < branch6Poll.branch7.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch6Poll.branch7[b].name;
                makethis.GetComponent<FolderObject>().size = branch6Poll.branch7[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch6Poll.branch7[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch6Poll.branch7[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch6Poll.branch7[b].mb;
                makethis.GetComponent<FolderObject>().b = branch6Poll.branch7[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch6Poll.branch7[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch6Poll.branch7[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch6Poll.branch7[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch6Poll.branch7[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch6Poll.branch7[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 8)
        {
            for (int b = 0; b < branch7Poll.branch8.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch7Poll.branch8[b].name;
                makethis.GetComponent<FolderObject>().size = branch7Poll.branch8[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch7Poll.branch8[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch7Poll.branch8[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch7Poll.branch8[b].mb;
                makethis.GetComponent<FolderObject>().b = branch7Poll.branch8[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch7Poll.branch8[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch7Poll.branch8[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch7Poll.branch8[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch7Poll.branch8[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch7Poll.branch8[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 9)
        {
            for (int b = 0; b < branch8Poll.branch9.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch8Poll.branch9[b].name;
                makethis.GetComponent<FolderObject>().size = branch8Poll.branch9[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch8Poll.branch9[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch8Poll.branch9[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch8Poll.branch9[b].mb;
                makethis.GetComponent<FolderObject>().b = branch8Poll.branch9[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch8Poll.branch9[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch8Poll.branch9[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch8Poll.branch9[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch8Poll.branch9[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch8Poll.branch9[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 10)
        {
            for (int b = 0; b < branch9Poll.branch10.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch9Poll.branch10[b].name;
                makethis.GetComponent<FolderObject>().size = branch9Poll.branch10[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch9Poll.branch10[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch9Poll.branch10[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch9Poll.branch10[b].mb;
                makethis.GetComponent<FolderObject>().b = branch9Poll.branch10[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch9Poll.branch10[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch9Poll.branch10[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch9Poll.branch10[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch9Poll.branch10[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch9Poll.branch10[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 11)
        {
            for (int b = 0; b < branch10Poll.branch11.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch10Poll.branch11[b].name;
                makethis.GetComponent<FolderObject>().size = branch10Poll.branch11[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch10Poll.branch11[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch10Poll.branch11[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch10Poll.branch11[b].mb;
                makethis.GetComponent<FolderObject>().b = branch10Poll.branch11[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch10Poll.branch11[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch10Poll.branch11[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch10Poll.branch11[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch10Poll.branch11[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch10Poll.branch11[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 12)
        {
            for (int b = 0; b < branch11Poll.branch12.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch11Poll.branch12[b].name;
                makethis.GetComponent<FolderObject>().size = branch11Poll.branch12[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch11Poll.branch12[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch11Poll.branch12[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch11Poll.branch12[b].mb;
                makethis.GetComponent<FolderObject>().b = branch11Poll.branch12[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch11Poll.branch12[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch11Poll.branch12[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch11Poll.branch12[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch11Poll.branch12[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch11Poll.branch12[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 13)
        {
            for (int b = 0; b < branch12Poll.branch13.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch12Poll.branch13[b].name;
                makethis.GetComponent<FolderObject>().size = branch12Poll.branch13[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch12Poll.branch13[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch12Poll.branch13[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch12Poll.branch13[b].mb;
                makethis.GetComponent<FolderObject>().b = branch12Poll.branch13[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch12Poll.branch13[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch12Poll.branch13[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch12Poll.branch13[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch12Poll.branch13[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch12Poll.branch13[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 14)
        {
            for (int b = 0; b < branch13Poll.branch14.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch13Poll.branch14[b].name;
                makethis.GetComponent<FolderObject>().size = branch13Poll.branch14[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch13Poll.branch14[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch13Poll.branch14[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch13Poll.branch14[b].mb;
                makethis.GetComponent<FolderObject>().b = branch13Poll.branch14[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch13Poll.branch14[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch13Poll.branch14[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch13Poll.branch14[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch13Poll.branch14[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch13Poll.branch14[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 15)
        {
            for (int b = 0; b < branch14Poll.branch15.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch14Poll.branch15[b].name;
                makethis.GetComponent<FolderObject>().size = branch14Poll.branch15[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch14Poll.branch15[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch14Poll.branch15[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch14Poll.branch15[b].mb;
                makethis.GetComponent<FolderObject>().b = branch14Poll.branch15[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch14Poll.branch15[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch14Poll.branch15[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch14Poll.branch15[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch14Poll.branch15[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch14Poll.branch15[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 16)
        {
            for (int b = 0; b < branch15Poll.branch16.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch15Poll.branch16[b].name;
                makethis.GetComponent<FolderObject>().size = branch15Poll.branch16[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch15Poll.branch16[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch15Poll.branch16[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch15Poll.branch16[b].mb;
                makethis.GetComponent<FolderObject>().b = branch15Poll.branch16[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch15Poll.branch16[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch15Poll.branch16[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch15Poll.branch16[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch15Poll.branch16[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch15Poll.branch16[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 17)
        {
            for (int b = 0; b < branch16Poll.branch17.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch16Poll.branch17[b].name;
                makethis.GetComponent<FolderObject>().size = branch16Poll.branch17[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch16Poll.branch17[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch16Poll.branch17[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch16Poll.branch17[b].mb;
                makethis.GetComponent<FolderObject>().b = branch16Poll.branch17[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch16Poll.branch17[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch16Poll.branch17[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch16Poll.branch17[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch16Poll.branch17[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch16Poll.branch17[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 18)
        {
            for (int b = 0; b < branch17Poll.branch18.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch17Poll.branch18[b].name;
                makethis.GetComponent<FolderObject>().size = branch17Poll.branch18[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch17Poll.branch18[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch17Poll.branch18[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch17Poll.branch18[b].mb;
                makethis.GetComponent<FolderObject>().b = branch17Poll.branch18[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch17Poll.branch18[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch17Poll.branch18[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch17Poll.branch18[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch17Poll.branch18[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch17Poll.branch18[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
        if (branchNumber == 19)
        {
            for (int b = 0; b < branch18Poll.branch19.Length; b++)
            {
                //instantiate script
                GameObject makethis = Instantiate(folderPrefab, transform.position, transform.rotation) as GameObject;
                makethis.transform.parent = folderPlace[b].transform;
                makethis.transform.position = folderPlace[b].transform.position;
                makethis.GetComponent<FolderObject>().name = branch18Poll.branch19[b].name;
                makethis.GetComponent<FolderObject>().size = branch18Poll.branch19[b].size;
                makethis.GetComponent<FolderObject>().irritate = branch18Poll.branch19[b].irritate;
                makethis.GetComponent<FolderObject>().gb = branch18Poll.branch19[b].gb;
                makethis.GetComponent<FolderObject>().mb = branch18Poll.branch19[b].mb;
                makethis.GetComponent<FolderObject>().b = branch18Poll.branch19[b].b;
                makethis.GetComponent<FolderObject>().isFolder = branch18Poll.branch19[b].isFolder;
                makethis.GetComponent<FolderObject>().isRar = branch18Poll.branch19[b].isRar;
                makethis.GetComponent<FolderObject>().isImage = branch18Poll.branch19[b].isImage;
                makethis.GetComponent<FolderObject>().isMovie = branch18Poll.branch19[b].isMovie;
                makethis.GetComponent<FolderObject>().isDoc = branch18Poll.branch19[b].isDoc;
                makethis.GetComponent<FolderObject>().folderNumber = b;
            }
        }
    }

    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        sliderIrritate = FindObjectOfType<SliderIrritate>();
        freeSpaceController = FindObjectOfType<FreeSpaceController>();
        dataController = FindObjectOfType<DataController>();
        roundNumber = DataController.roundNumber;

        roundData = dataController.GetAllRoundData(roundNumber);
        timeRemaining = roundData.timePerRound;
        timeRemainingStart = timeRemaining;

        NewSetOfFolders();

    }



    public void Death()
    {
        print("death");
        sceneLoader.Lose();
    }
    public void Victory()
    {

        if (DataController.roundNumber <2)
        {
            sceneLoader.Win();
        }
        else
        {
            sceneLoader.GoToEnd();
        }
        print("victory!!!");
    }

    void Update()
    {
        for (int b = 0; b < 8; b++)
        {
            foreach (Transform child in folderPlace[b].transform)
            {
                if (child.gameObject.GetComponent<FolderObject>().name == "")
                {
                    child.gameObject.SetActive(false);
                }
            }
        }

    }
}