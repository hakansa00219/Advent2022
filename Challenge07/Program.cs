﻿using System.Collections;
using System.Data;
using System.Drawing;

namespace Challenge07
{
    internal class Program
    {
        public static string tempInput = "$ cd /\r\n$ ls\r\ndir a\r\n14848514 b.txt\r\n8504156 c.dat\r\ndir d\r\n$ cd a\r\n$ ls\r\ndir e\r\n29116 f\r\n2557 g\r\n62596 h.lst\r\n$ cd e\r\n$ ls\r\n584 i\r\n$ cd ..\r\n$ cd ..\r\n$ cd d\r\n$ ls\r\n4060174 j\r\n8033020 d.log\r\n5626152 d.ext\r\n7214296 k";
        public static string input = "$ cd /\r\n$ ls\r\ndir plws\r\ndir pwlbgbz\r\ndir pwtpltr\r\ndir szn\r\n$ cd plws\r\n$ ls\r\ndir ffpzc\r\ndir frcmjzts\r\n92461 nbvnzg\r\ndir phqcg\r\n21621 vqgsglwq\r\n$ cd ffpzc\r\n$ ls\r\n48459 dzdfc.vqq\r\n143107 jql.jzl\r\n208330 mmnvqn.hqb\r\n290122 svjvhflz\r\n218008 wjlmgq\r\n$ cd ..\r\n$ cd frcmjzts\r\n$ ls\r\ndir bsltmjz\r\ndir jfzgrbm\r\n$ cd bsltmjz\r\n$ ls\r\n34237 dzdfc.vqq\r\n58741 mdgdhqgw\r\n$ cd ..\r\n$ cd jfzgrbm\r\n$ ls\r\n132811 fcmpng\r\n103661 lgt.swt\r\n173031 vqgsglwq\r\n29134 wprjfg.zbr\r\n$ cd ..\r\n$ cd ..\r\n$ cd phqcg\r\n$ ls\r\n955 jgfs.zjw\r\n$ cd ..\r\n$ cd ..\r\n$ cd pwlbgbz\r\n$ ls\r\ndir gbg\r\ndir mjzhcwrd\r\ndir njcscpj\r\ndir sphbzn\r\ndir tbgjpphc\r\n55938 tvrfpczc.djm\r\n4840 twd\r\n$ cd gbg\r\n$ ls\r\n287003 fcsjl.bzm\r\ndir wgq\r\n$ cd wgq\r\n$ ls\r\n22963 fcsjl.fcm\r\n$ cd ..\r\n$ cd ..\r\n$ cd mjzhcwrd\r\n$ ls\r\n228632 clfnpmbq.zmb\r\n28276 dzdfc.vqq\r\n2982 tdbg.wgn\r\n$ cd ..\r\n$ cd njcscpj\r\n$ ls\r\ndir dqzgqgv\r\n275186 ffpzc\r\n192491 gjnflc.plq\r\n$ cd dqzgqgv\r\n$ ls\r\n70309 dzdfc.vqq\r\n56139 fcsjl\r\n142095 sgwz.cdz\r\ndir snjntth\r\ndir sphbzn\r\n284618 wjlmgq\r\n$ cd snjntth\r\n$ ls\r\n51918 ffpzc\r\ndir vrfgfds\r\n$ cd vrfgfds\r\n$ ls\r\n155233 jlscz\r\n$ cd ..\r\n$ cd ..\r\n$ cd sphbzn\r\n$ ls\r\ndir qbzwrrw\r\ndir qwpzn\r\n$ cd qbzwrrw\r\n$ ls\r\n278531 fcsjl.tqj\r\n211591 snjntth.gpd\r\n$ cd ..\r\n$ cd qwpzn\r\n$ ls\r\n174183 vqgsglwq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd sphbzn\r\n$ ls\r\n185471 bsltmjz.fqz\r\ndir bsvh\r\ndir fvzcs\r\ndir ndw\r\ndir nlml\r\ndir pcbt\r\n286260 zhcmrpvt\r\n$ cd bsvh\r\n$ ls\r\n130814 wjlmgq\r\n$ cd ..\r\n$ cd fvzcs\r\n$ ls\r\ndir cgmv\r\ndir ggzwljr\r\n298241 qvzghdpw.lms\r\ndir snjntth\r\ndir sphbzn\r\n$ cd cgmv\r\n$ ls\r\n46843 dzdfc.vqq\r\ndir lmqcbbm\r\ndir rstcqsmd\r\n215261 snjntth\r\n$ cd lmqcbbm\r\n$ ls\r\n229898 bdmbvgp\r\n25529 ffpzc.stm\r\n16871 lnpjzvg.qlj\r\n$ cd ..\r\n$ cd rstcqsmd\r\n$ ls\r\n289038 zrbbbwng.smf\r\n$ cd ..\r\n$ cd ..\r\n$ cd ggzwljr\r\n$ ls\r\n198200 bcthn\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\n191672 fwp.phf\r\n68229 hzs.zpg\r\ndir pggcwb\r\n222426 qbv.bwj\r\ndir snjntth\r\n155354 vmqcm\r\n$ cd pggcwb\r\n$ ls\r\n154272 fqztwvnv.lvv\r\ndir pdjg\r\n62393 vqgsglwq\r\ndir wjhrtg\r\n$ cd pdjg\r\n$ ls\r\n260644 gvhlrcf\r\n209906 wpls.pbd\r\n$ cd ..\r\n$ cd wjhrtg\r\n$ ls\r\n148640 dljf.zrq\r\n172168 dzdfc.vqq\r\n196203 hjdphcfm\r\n247620 sgwz.cdz\r\n$ cd ..\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\n37467 ndlshlmj.cjq\r\n257404 snjntth.nsf\r\n$ cd ..\r\n$ cd ..\r\n$ cd sphbzn\r\n$ ls\r\n64082 bfdv.lwv\r\ndir bsltmjz\r\n58942 dzdfc.vqq\r\ndir snjntth\r\n$ cd bsltmjz\r\n$ ls\r\ndir bsqqdr\r\n266007 fcsjl.gfm\r\ndir ffpzc\r\ndir frsmrd\r\n72122 nthnhzwf\r\n286705 wjlmgq\r\n$ cd bsqqdr\r\n$ ls\r\n117496 wcqt\r\n$ cd ..\r\n$ cd ffpzc\r\n$ ls\r\n280224 mmnvqn.hqb\r\n105346 vrr\r\n$ cd ..\r\n$ cd frsmrd\r\n$ ls\r\n111509 sphbzn.shz\r\n$ cd ..\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\n177491 mplj\r\n9029 pvbz.jwn\r\n92891 snjntth.zrv\r\n203356 vnnnw.gql\r\n134728 vqgsglwq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ndw\r\n$ ls\r\n241303 bht.rpj\r\n173068 vqgsglwq\r\n$ cd ..\r\n$ cd nlml\r\n$ ls\r\n228982 hzglfpvq.ftt\r\n114981 sgwz.cdz\r\n$ cd ..\r\n$ cd pcbt\r\n$ ls\r\ndir bsltmjz\r\ndir ffpzc\r\ndir fjsjwfg\r\ndir fwm\r\ndir jvwt\r\n227943 tmr.jdc\r\ndir vwpqzdwh\r\n31258 wjlmgq\r\n$ cd bsltmjz\r\n$ ls\r\n177750 bsltmjz.spj\r\ndir ffpzc\r\ndir flrpwfs\r\n138824 mtmdtcpv.cfj\r\n165770 wzqwczj.qwn\r\n$ cd ffpzc\r\n$ ls\r\n179645 snjntth.dss\r\n$ cd ..\r\n$ cd flrpwfs\r\n$ ls\r\n60566 wvjq.gmm\r\n$ cd ..\r\n$ cd ..\r\n$ cd ffpzc\r\n$ ls\r\n97847 qzhhtmd.bhw\r\n1197 vqgsglwq\r\n$ cd ..\r\n$ cd fjsjwfg\r\n$ ls\r\n152232 dnsdd.jgz\r\n181301 gsb.wsh\r\ndir jqpb\r\ndir jscbg\r\ndir snjntth\r\n227677 snjntth.vvg\r\ndir sphbzn\r\n75358 vqgsglwq\r\n2589 wjlmgq\r\n$ cd jqpb\r\n$ ls\r\n253403 mmnvqn.hqb\r\n108325 rvq.mrc\r\n$ cd ..\r\n$ cd jscbg\r\n$ ls\r\ndir dtm\r\ndir gsdnz\r\n208269 prh\r\n25977 qdzljgh\r\n169262 vmnq.mth\r\n$ cd dtm\r\n$ ls\r\n80072 gzqnb\r\n$ cd ..\r\n$ cd gsdnz\r\n$ ls\r\ndir dsqzjs\r\n297895 sgwz.cdz\r\n129983 vqgsglwq\r\n$ cd dsqzjs\r\n$ ls\r\n2621 jqrlsf.gzs\r\n164844 snjntth\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\n118553 cbhql\r\ndir ffpzc\r\ndir snjntth\r\n$ cd ffpzc\r\n$ ls\r\ndir lmn\r\n12104 tvlwn.vhh\r\n$ cd lmn\r\n$ ls\r\n46401 bsltmjz\r\n96888 shrnqhvq\r\n$ cd ..\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\ndir snjntth\r\ndir vlnfhbq\r\ndir wpwl\r\n$ cd snjntth\r\n$ ls\r\ndir ctj\r\n$ cd ctj\r\n$ ls\r\n82485 fcsjl.lfl\r\n$ cd ..\r\n$ cd ..\r\n$ cd vlnfhbq\r\n$ ls\r\n250106 qvf\r\n$ cd ..\r\n$ cd wpwl\r\n$ ls\r\n153950 cmsd.rlg\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd sphbzn\r\n$ ls\r\ndir glgq\r\n$ cd glgq\r\n$ ls\r\n285182 wjlmgq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd fwm\r\n$ ls\r\n251865 ffpzc.qgb\r\n279522 zvvpfqtp\r\n$ cd ..\r\n$ cd jvwt\r\n$ ls\r\n48990 bsltmjz.nzp\r\n219604 ffpzc\r\n69573 mvmdfzr.lwb\r\n$ cd ..\r\n$ cd vwpqzdwh\r\n$ ls\r\n267581 pvcch\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd tbgjpphc\r\n$ ls\r\n255571 dstpcgr.tfq\r\ndir fdbwbrpp\r\ndir gjzwh\r\ndir hjvrtjt\r\ndir rhzczj\r\n292888 sgwz.cdz\r\ndir wlzhr\r\n149395 wnfzrqgz.dtn\r\n$ cd fdbwbrpp\r\n$ ls\r\ndir ffpzc\r\ndir qbrth\r\n51164 qprp\r\ndir slpt\r\n117026 sphbzn\r\n295685 vqgsglwq\r\ndir znmj\r\n$ cd ffpzc\r\n$ ls\r\ndir jhnzrdvb\r\n$ cd jhnzrdvb\r\n$ ls\r\n217775 ffpzc.sgw\r\n$ cd ..\r\n$ cd ..\r\n$ cd qbrth\r\n$ ls\r\n183969 lpbwgfjv.vcg\r\n47333 wjlmgq\r\n$ cd ..\r\n$ cd slpt\r\n$ ls\r\n32343 tqhtj.jwz\r\n$ cd ..\r\n$ cd znmj\r\n$ ls\r\n55058 mmnvqn.hqb\r\n$ cd ..\r\n$ cd ..\r\n$ cd gjzwh\r\n$ ls\r\ndir dvcbcd\r\n202530 dzdfc.vqq\r\ndir fsgz\r\ndir hfrrqq\r\n54897 jlzn.qsn\r\n16097 ldzqsbb.jzl\r\n225078 pswccrd\r\ndir rqqmldw\r\n292464 rzrdhbp.vld\r\ndir ssqbqqp\r\ndir zsztqrc\r\n$ cd dvcbcd\r\n$ ls\r\n187837 dzdfc.vqq\r\ndir jlwtvf\r\ndir jnjvshs\r\n164053 nrf.fqd\r\n5665 tlp.jmt\r\n13801 wjlmgq\r\n$ cd jlwtvf\r\n$ ls\r\n219985 sphbzn.dvj\r\n$ cd ..\r\n$ cd jnjvshs\r\n$ ls\r\ndir bsltmjz\r\ndir nrpm\r\n$ cd bsltmjz\r\n$ ls\r\n152972 qgdqj\r\n$ cd ..\r\n$ cd nrpm\r\n$ ls\r\n18509 wjlmgq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd fsgz\r\n$ ls\r\n224576 mmnvqn.hqb\r\n$ cd ..\r\n$ cd hfrrqq\r\n$ ls\r\ndir bwgsnfvb\r\ndir fcsjl\r\n294608 ffpzc.gvm\r\n136880 qjcgtw\r\ndir sphbzn\r\n$ cd bwgsnfvb\r\n$ ls\r\n29735 dzdfc.vqq\r\ndir wstmzfml\r\n$ cd wstmzfml\r\n$ ls\r\n158447 bnvhbvvc.nrt\r\n59889 jclclgd\r\n$ cd ..\r\n$ cd ..\r\n$ cd fcsjl\r\n$ ls\r\n138297 ffpzc.szw\r\n$ cd ..\r\n$ cd sphbzn\r\n$ ls\r\ndir wqdths\r\n$ cd wqdths\r\n$ ls\r\n8326 cgvtw.jpz\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd rqqmldw\r\n$ ls\r\n226757 dzdfc.vqq\r\n115055 mwb.btc\r\ndir qpts\r\n298524 sgwz.cdz\r\n$ cd qpts\r\n$ ls\r\n60860 bsltmjz.frp\r\ndir fcsjl\r\n94904 sgwz.cdz\r\ndir wnmqqspz\r\n$ cd fcsjl\r\n$ ls\r\n25082 mmnvqn.hqb\r\n$ cd ..\r\n$ cd wnmqqspz\r\n$ ls\r\n165529 sgwz.cdz\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ssqbqqp\r\n$ ls\r\n192477 pvrgm\r\n$ cd ..\r\n$ cd zsztqrc\r\n$ ls\r\n254053 lht.htn\r\n$ cd ..\r\n$ cd ..\r\n$ cd hjvrtjt\r\n$ ls\r\n189942 fwps\r\n$ cd ..\r\n$ cd rhzczj\r\n$ ls\r\n36502 bmtfr\r\ndir ffjz\r\n35148 nctfhmzm.vsz\r\ndir qdgjzcz\r\n208196 rwql\r\n79863 sgwz.cdz\r\ndir snjntth\r\n$ cd ffjz\r\n$ ls\r\ndir grsvhwm\r\n$ cd grsvhwm\r\n$ ls\r\n50231 fwj.rdv\r\ndir snjntth\r\n$ cd snjntth\r\n$ ls\r\ndir dtbgb\r\n$ cd dtbgb\r\n$ ls\r\n150245 vdflm.lmq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd qdgjzcz\r\n$ ls\r\n222389 dzdfc.vqq\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\n56794 mmnvqn.hqb\r\n$ cd ..\r\n$ cd ..\r\n$ cd wlzhr\r\n$ ls\r\n116628 bsltmjz\r\n60122 jqpbsgnr.fgb\r\n252605 lfss\r\n300065 qwjdl.vhr\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd pwtpltr\r\n$ ls\r\ndir dplsvrhl\r\n140951 gwtfzqvd.znb\r\ndir jbvdb\r\ndir jst\r\ndir qhjv\r\ndir snjntth\r\n$ cd dplsvrhl\r\n$ ls\r\n272101 fcsjl\r\ndir ffpzc\r\n58852 mmnvqn.hqb\r\ndir mnhntjz\r\n91899 sgwz.cdz\r\n228077 snjntth.btv\r\n$ cd ffpzc\r\n$ ls\r\n5499 bsltmjz\r\ndir qmfwpjhl\r\ndir rsrb\r\ndir wgt\r\n$ cd qmfwpjhl\r\n$ ls\r\n300362 dzdfc.vqq\r\n$ cd ..\r\n$ cd rsrb\r\n$ ls\r\n252983 dzdfc.vqq\r\n107744 ltssrgqb.zvj\r\n214895 rhglgcwr.wpw\r\n249727 sgwz.cdz\r\n$ cd ..\r\n$ cd wgt\r\n$ ls\r\n141984 dzdfc.vqq\r\n194686 mmnvqn.hqb\r\n258023 pgr\r\n$ cd ..\r\n$ cd ..\r\n$ cd mnhntjz\r\n$ ls\r\ndir bdvght\r\ndir jprwchh\r\ndir snjntth\r\n$ cd bdvght\r\n$ ls\r\n243166 vpsvjdq.wsn\r\n$ cd ..\r\n$ cd jprwchh\r\n$ ls\r\n178943 bmpc.bjb\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\ndir nlbm\r\ndir zjmjntff\r\n$ cd nlbm\r\n$ ls\r\n33050 fcsjl.rcc\r\ndir sphbzn\r\n17446 wjlmgq\r\n$ cd sphbzn\r\n$ ls\r\n214563 prrfhff.pbp\r\n$ cd ..\r\n$ cd ..\r\n$ cd zjmjntff\r\n$ ls\r\n82134 sgwz.cdz\r\n52203 vrtlgdq.crp\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd jbvdb\r\n$ ls\r\ndir wmtjh\r\n$ cd wmtjh\r\n$ ls\r\ndir ggvwn\r\n$ cd ggvwn\r\n$ ls\r\n192285 spqvmf.sdh\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd jst\r\n$ ls\r\ndir bsltmjz\r\n212740 dzdfc.vqq\r\ndir gncztvtb\r\ndir jsqjcqnt\r\n286257 jvs\r\n36654 sdcsm.mbg\r\n192040 sgwz.cdz\r\ndir tbqphzb\r\ndir vdcqgts\r\n285843 wjlmgq\r\n$ cd bsltmjz\r\n$ ls\r\n215705 snjntth.gpv\r\n213665 wjlmgq\r\n$ cd ..\r\n$ cd gncztvtb\r\n$ ls\r\n229298 vqgsglwq\r\n$ cd ..\r\n$ cd jsqjcqnt\r\n$ ls\r\ndir bsltmjz\r\ndir fcsjl\r\ndir ffpzc\r\ndir sphbzn\r\n70864 vqgsglwq\r\n$ cd bsltmjz\r\n$ ls\r\n14981 pqzffzjc\r\n$ cd ..\r\n$ cd fcsjl\r\n$ ls\r\n140328 jwhczwbc\r\n$ cd ..\r\n$ cd ffpzc\r\n$ ls\r\n213650 mmnvqn.hqb\r\n$ cd ..\r\n$ cd sphbzn\r\n$ ls\r\ndir psmtphhq\r\ndir sphbzn\r\n$ cd psmtphhq\r\n$ ls\r\ndir ffpzc\r\n123131 tzgwd\r\n$ cd ffpzc\r\n$ ls\r\n49737 cfngvmd\r\ndir gcnrp\r\n172799 gmd.cwl\r\ndir llnztjf\r\ndir nbqs\r\n79661 rrqz\r\n$ cd gcnrp\r\n$ ls\r\n283 vqnrgl.vwp\r\n$ cd ..\r\n$ cd llnztjf\r\n$ ls\r\n63263 tjhm.bwh\r\n$ cd ..\r\n$ cd nbqs\r\n$ ls\r\ndir vssmq\r\n$ cd vssmq\r\n$ ls\r\n88980 dzdfc.vqq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd sphbzn\r\n$ ls\r\n20140 fcsjl.zrs\r\n260579 snjntth\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd tbqphzb\r\n$ ls\r\n93470 sgwz.cdz\r\n$ cd ..\r\n$ cd vdcqgts\r\n$ ls\r\n223564 dzdfc.vqq\r\ndir ffpzc\r\ndir gwhfgwf\r\ndir nbjtqnng\r\ndir snjntth\r\n$ cd ffpzc\r\n$ ls\r\n42813 qwwmw.nmt\r\n$ cd ..\r\n$ cd gwhfgwf\r\n$ ls\r\n59918 jvfv.mpm\r\ndir mjl\r\n211039 pcwl\r\n$ cd mjl\r\n$ ls\r\n13004 pgjb.tpq\r\n195995 tms.fjz\r\n$ cd ..\r\n$ cd ..\r\n$ cd nbjtqnng\r\n$ ls\r\n107058 dzdfc.vqq\r\ndir ldrsd\r\n111631 vqgsglwq\r\n104599 wbzmdljw.tjq\r\n155747 wjlmgq\r\n$ cd ldrsd\r\n$ ls\r\n107439 jvjm\r\n$ cd ..\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\n242680 fgrt.gng\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd qhjv\r\n$ ls\r\ndir bmnm\r\n68453 hjjpdgn.hwl\r\ndir sjlbj\r\ndir vqnrj\r\n$ cd bmnm\r\n$ ls\r\n1238 vqgsglwq\r\n$ cd ..\r\n$ cd sjlbj\r\n$ ls\r\n44239 wzzbtmrz.gml\r\n$ cd ..\r\n$ cd vqnrj\r\n$ ls\r\n3286 bsltmjz.qlc\r\n$ cd ..\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\n130833 blm.wmt\r\ndir snjntth\r\ndir tcnmbcgg\r\n218869 wjlmgq\r\n$ cd snjntth\r\n$ ls\r\ndir snmrdfbt\r\n$ cd snmrdfbt\r\n$ ls\r\n281025 bzrsds.lfg\r\n$ cd ..\r\n$ cd ..\r\n$ cd tcnmbcgg\r\n$ ls\r\n194998 fcsjl\r\ndir qdrmpqgn\r\ndir rzqd\r\ndir tcsds\r\n$ cd qdrmpqgn\r\n$ ls\r\n165713 qmzgt.tnc\r\n$ cd ..\r\n$ cd rzqd\r\n$ ls\r\ndir cwhnmlv\r\n57819 fcsjl\r\n246864 pjnzdvd.gjm\r\n$ cd cwhnmlv\r\n$ ls\r\n287539 mmnvqn.hqb\r\n215636 pbnjt.zbn\r\n124638 sqd\r\n$ cd ..\r\n$ cd ..\r\n$ cd tcsds\r\n$ ls\r\n78812 gfmgb.wqj\r\n218987 hnhfvz.dln\r\n209640 mzzhqlq.zqp\r\n102492 nml.ppg\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd szn\r\n$ ls\r\ndir fcsjl\r\ndir snjntth\r\ndir zjbp\r\n$ cd fcsjl\r\n$ ls\r\n158019 jsv.pmz\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\n229510 dfvpvp\r\n191061 fgplbptq.jlt\r\ndir lfb\r\n234911 lfsrwr.wcb\r\ndir lrfcgzl\r\n48031 stbbw\r\n219691 vqgsglwq\r\ndir zshh\r\n$ cd lfb\r\n$ ls\r\ndir btj\r\n99591 dhrjbvvg.gwm\r\n137224 dzdfc.vqq\r\n201972 jtzmqsvj.wnd\r\n9704 mmnvqn.hqb\r\ndir pwg\r\n200308 snjntth.css\r\ndir wcmhcfm\r\ndir zwhvmln\r\n$ cd btj\r\n$ ls\r\ndir rnbzdfgn\r\n51799 wdhsm\r\ndir wvf\r\n$ cd rnbzdfgn\r\n$ ls\r\n117095 bsltmjz.tlv\r\n$ cd ..\r\n$ cd wvf\r\n$ ls\r\ndir ffpzc\r\ndir ncbmgpsc\r\ndir wtwrmjnt\r\n$ cd ffpzc\r\n$ ls\r\n249919 lsth.fmf\r\n$ cd ..\r\n$ cd ncbmgpsc\r\n$ ls\r\n147899 dzdfc.vqq\r\n$ cd ..\r\n$ cd wtwrmjnt\r\n$ ls\r\n252366 pvpdv.jwz\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd pwg\r\n$ ls\r\n280845 fcsjl.fjz\r\n44300 sgwz.cdz\r\ndir snjntth\r\n229605 vqgsglwq\r\n$ cd snjntth\r\n$ ls\r\n2053 pflvsnzs\r\n143522 sgwz.cdz\r\n$ cd ..\r\n$ cd ..\r\n$ cd wcmhcfm\r\n$ ls\r\n229329 qsznhwlw.vjg\r\n$ cd ..\r\n$ cd zwhvmln\r\n$ ls\r\ndir ffpzc\r\ndir tjjzbf\r\ndir wzcq\r\n$ cd ffpzc\r\n$ ls\r\ndir ncnj\r\n37497 vqgsglwq\r\n$ cd ncnj\r\n$ ls\r\n40920 htbjhjq\r\n$ cd ..\r\n$ cd ..\r\n$ cd tjjzbf\r\n$ ls\r\n47522 mczn.spd\r\n$ cd ..\r\n$ cd wzcq\r\n$ ls\r\n56662 ffpzc.vwp\r\ndir snjntth\r\n$ cd snjntth\r\n$ ls\r\n117276 wjlmgq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd lrfcgzl\r\n$ ls\r\n267485 rsjmpph.qqz\r\n$ cd ..\r\n$ cd zshh\r\n$ ls\r\ndir ffpzc\r\ndir gmn\r\ndir snjntth\r\n150048 tgtlh\r\n32020 thfr\r\n72152 vqgsglwq\r\n$ cd ffpzc\r\n$ ls\r\ndir snjntth\r\n$ cd snjntth\r\n$ ls\r\n224945 dpfpz\r\n$ cd ..\r\n$ cd ..\r\n$ cd gmn\r\n$ ls\r\n238996 sgwz.cdz\r\n$ cd ..\r\n$ cd snjntth\r\n$ ls\r\n86775 dzdfc.vqq\r\n19560 vshcmjj\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd zjbp\r\n$ ls\r\ndir fcsjl\r\n41522 nlvpb.fpf\r\ndir nmtjtd\r\n$ cd fcsjl\r\n$ ls\r\n276802 fcsjl.psm\r\n197934 sgwz.cdz\r\n$ cd ..\r\n$ cd nmtjtd\r\n$ ls\r\n47477 dvqmqlgw.ths\r\n51081 vqgsglwq";
        public static _Directory currentDirectory;
        public static _Directory rootDir;
        
        static void Main(string[] args)
        {
            string[] cleanedInput = input.Split("\r\n");
            //cleanedInput.ForEach((v) => Console.WriteLine(v));

            rootDir = new _Directory("/",null)
            {
                indent = 0,
            };

            currentDirectory = rootDir;
            cleanedInput.ForEach((v) => LineExamine(v));


            _Directory foundDir;
            long totalSize = 70000000;
            long requiredSize = 30000000;
            long usedSize = rootDir.TotalSize;
            long unusedSize = totalSize - usedSize;
            long missingSize = requiredSize - unusedSize;
            foundDir = rootDir;

            TraverseDirs(rootDir,missingSize,ref foundDir);

            Console.WriteLine(foundDir.TotalSize);
        }

        static void TraverseDirs(_Directory source, long missingSize, ref _Directory foundDir)
        {
            if(missingSize <= source.TotalSize &&
                source.TotalSize <= foundDir.TotalSize)
            {
                foundDir = source;
            }
            foreach (var dir in source.dirs)
            {
                TraverseDirs(dir, missingSize,ref foundDir);
            }
        }

        static void LineExamine(string line)
        {
            string[] temp = line.Split(' ');

            switch (temp.First())
            {
                case "$":
                    switch(temp[1])
                    {
                        case "cd":
                            switch (temp[2])
                            {
                                case "..":
                                    BackDirectory();
                                    break;
                                case "/":
                                    MoveOutermostDirectory();
                                    break;
                                default:
                                    EnterDirectory(temp[2]);
                                    break;
                            }
                            break;
                        case "ls":
                            ListCurrentDirectory();
                            break;
                        default:
                            break;
                    }
                    break;
                case "dir":
                    SetDirectory(temp[1]);
                    break;
                default:
                    if (int.TryParse(temp[0], out int result))
                    {
                        SetFile(result, temp[1]);
                    }
                    else
                    {
                        Console.WriteLine($"something wrong with {temp[0]}");
                    }
                    break;
            }
        }

        public static void MoveOutermostDirectory()
        {
            currentDirectory = rootDir;
            currentDirectory.parentDir = null;
        }
        public static void SetDirectory(string dirName)
        {
            currentDirectory.CreateDirectory(dirName, currentDirectory);
            Console.WriteLine(dirName + " --- " + currentDirectory);
        }

        public static void EnterDirectory(string dirName)
        {
            if(currentDirectory.dirs.FirstOrDefault(d => d.dirName == dirName) is not { } targetDirectory)
            {
                var newDirectory = new _Directory(dirName, currentDirectory);
                currentDirectory.dirs.Add(newDirectory);
                targetDirectory = newDirectory;
            }
            currentDirectory = targetDirectory;
        }
        public static void BackDirectory()
        {
            currentDirectory = currentDirectory.parentDir;
        }
        public static void ListCurrentDirectory()
        {
            //Skip
        }
        public static void SetFile(int size, string name)
        {
            currentDirectory.CreateFiles(name, size);
            if (size < 100000) Console.WriteLine($"Filename {name} , Size {size}");
        }


        public class _File
        {
            public string name;
            public int size;

            public _File(string name, int size)
            {
                this.name = name;
                this.size = size;
            }
        }
        public class _Directory
        {
            public string dirName = "";
            public int indent;
            public _Directory parentDir;
            public List<_File> files = new List<_File>();
            public List<_Directory> dirs = new List<_Directory>();
            public override string ToString()
            {
                return dirName;
            }
            public void CreateDirectory(string dirName, _Directory parentDir)
            {
                dirs.Add(new _Directory(dirName, parentDir));

                if (parentDir != null) indent = parentDir.indent + 1;
            }
            public void CreateFiles(string name, int size)
            {
                files.Add(new _File(name, size));
            }
            public bool ContainsDirectory(string dirName) => dirs.Any(d => d.dirName == dirName);

            public long TotalSize
            {
                get
                {
                    long size = 0;
                    //Console.WriteLine(dirName);
                    foreach (var file in files)
                    {
                        size += file.size;

                    }

                    foreach (var d in dirs)
                    {
                        size += d.TotalSize;
                    }
                    return size;
                }


            }
            public _Directory(string dirName, _Directory parentDir)
            {
                this.parentDir = parentDir;
                this.dirName = dirName;
            }
        }  
    }

    static class ArrayExtension
    {
        public static void ForEach<T>(this T[] items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }
    }
    
}

