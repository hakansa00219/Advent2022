using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Challenge03
{
    internal class Program
    {
        public static string input = "BzRmmzZHzVBzgVQmZLPtqqffPqWqJmPLlL\r\nhpvvTDcrCjhpcrvcGGhfLHMlLtMCqflNlWPJlJ\r\nhGjhncHhGnhbTHczBBZVVSbRwgSgRV\r\nrWVQjPQQjGRWNSrWrPjcptwBpqqJBtJBBcZgMdtq\r\nzzmmpzfTCFpTlMlJJwBgMlqMBt\r\nTvLszpbhhTLmsnRQPDQGWDWRvQSR\r\nzGzvLlGlQHLGBQZlhBWhdjRdmdWRcjPj\r\nfTJNfTfNSRWPhjdjfj\r\npbsbVVnpSnbVTprnbqqrzvLLgQlGLPLHll\r\nZCCCsWvNvmsCsCmZLZmgMLRpQMhwQRpQRfphfprpTfpM\r\ntlncPjzlndctbzcPPBcjwDphwrfGGDffbDRpDTGG\r\ncdqnddwzqjNVWVLZZLZq\r\nDTLbDbRrlQbwhhNrmmfwdt\r\nzzMJMzjCjJJjvLjMPJpcgPpzfhHdfqWcqddwtwfqdttcNtdN\r\npJCzVpCvDZBLsVRQ\r\nSTzBBbJzRRBZBRTqCCsfZLtNNLClCsfh\r\njsQnnQjjHcvQFrcPwCmtLCNlvDfftfff\r\nsGFscMQQMMpqzqbMbd\r\nQlNDWGsjQjgQllWQsbtzqTJczTJcbFmmFJJP\r\nMhLrhgLVndRmzJFzVqqJqP\r\npSLnMdwhwdRZRSwhLZwLhdGWQjlsgWjNQWWSvgBsWDlj\r\nTHjSRFSddTjdBTcPLcVVvVBw\r\nGzWnWfndWfznDfsnsBsPVwVwPPLL\r\nzNflzJWqqzQDdSStHNZNpFFtbj\r\nFSzDmsFSFlDlBzqVjqHHjHHpVgHLbp\r\nrTrTtTQQntRQnQJQgggHZttVgHLBLhZL\r\nWTJJRRQCRRJTRdBCRdvRNDFSWFMPmDlPPSsNPSzS\r\nWQldlMtMVQgVMQHnDGbHGGnRnQmD\r\nrqcZPrCFjmHlbGjZ\r\nzSScchqwchBzTzFzhhSlcCwNtdVWWJgsVdMtWNgNVWTJTd\r\nlMZqjMWllrTTspjprWWSSwgWNSVNDmWGVwFwgN\r\ncdCCdLHcnndHJnmCRntLBnRzDvFNtNDVzgSgwDgFNVzFVv\r\nBRLcCCJCmJdcRhfjPPZphrlrPqlZ\r\nGdGqcrrZGDrvDJJqJHcBvmFFgmFMMgMgBtMLTssLmF\r\nNbPVPDlljPmTmsTj\r\nVfQDhflCCRWdcrQwJvvnJv\r\nRLcWgLCqqPQLcqZwzHgwmmrmmtgwTw\r\nDhbhNrMpnJSDJwVTHmmTVnTTVj\r\nlrsvblMDlcWcfQPQ\r\nPVldlphHwGwJJGdjZZWsRbbsGsNWrWQbNbQR\r\nSqcDvTmDLtfmSmtqppfqzTgTQBrRQsbCFWbNNFQFBBrRbLNb\r\nMgtmTgtfpqVlnVddZMwV\r\nBdmfmPBPSbSNdGSdvWrwcZrccZPPcZnH\r\njzzLsjsMRlQQVHwswvvZrCHrrT\r\nVqhzVFzplFlpLwpMphLRQQVRmSqgbdGtNJBmNSmgGbtggSgt\r\nDHVpNZjdZjFZWVFHpvFvzmlRzPnlfznFRz\r\nlrTBTsBwwMbrrwLPPfwGmGzvRf\r\nscrtMhMCtJBBBclbHdHttWZWDSqDSjHj\r\nwzqsPmqsbsfqBwPMNRMMZcZmFFNtZM\r\nCgCnhlvvLJgcRFNNBdCpWM\r\nQnQrVgHSvVHjbjTGBbbTHb\r\nHdrVrdqFDdZVmHgRmDRFHMnTdTssMGnLnPJLbPTbCs\r\nSczlScjwcNzplNzQSSfjwQSrTGGsbTsnTCnGTMCMLMGGbN\r\nwQlfjrhfhQFHqZhRZRtD\r\nRsfJDGJvzPNcjpddSWJWMd\r\nLLCbBCwCrCmVVnrmhQFmbVhdcdlWpjZzSpMdWSpcWczSBj\r\nrrLCbTwnHTvzvNGT\r\nwPhPhbCqqSCrtJDlqvlrJr\r\nRVVZddLFRZZcQLvJJtzptlgPJp\r\nTVQRZGVncFdTGWZdCNShHhfPNwwsWPwb\r\ndzLVzPSgrgDDDCMSMLLPwFmdTTcsvmwNwjNsHcFF\r\nnWBGntQfGNGBflWBBqlpRQGbWFvjwsbsFswbvTHjjbmHTc\r\ntBNJBnGBflQnDPJrPhDgrPVg\r\nVtWztWtqpqzWpWzqjNRjNpWTmrrmrSbnmJwSJwnMPrCSJVwM\r\nsDHsBDhBdsBZGcHvLHDLhhCSnRSwCJMZrPbmnMbJSCSR\r\nccLRhgsLBdRsdHNTFFNNgqTglqzF\r\nhztlmDhPhgPlPNNgmZMCbmwwQjcwjjwMjVCd\r\nRSJRrRqnqQJFqvnTGrHCcHHCCHHbHHMcMvdM\r\nqGJsnQTRsStsftPlhPNl\r\nBFFBLPRCwsLwhlPlRmhcGGrbmmGjfNTTnp\r\nVJMVpzgqggJnrjmjNcMjmT\r\nVqdSZtQgZvtdzqHqHtVZdVQpCDWWFdwlRPDpWPPBCswlWD\r\nfCWCsjPzcbzwRSzVTzhhDLqvdg\r\nTmJtrNJrBLSLJqgS\r\nptNTQFHrZlnpFPwsWMbRjCpcjR\r\nnJmQNCmbmlllmbClbfMLjMFqbGBsdLFq\r\nZcgTWcTnMqqMTBqF\r\ntPgctSnPctZZgDWzZgQHwNmHlhlmzlQhlJlw\r\nZpTCwpffdslvgShCBhqhRz\r\nFDMPnNFNmBPzvRPRBg\r\nnNgMrnnDGjDmJMmnFdZTTsdsrZrslcwcQr\r\npTmczpCldcdDDnPttpvWSqbpJf\r\njgjRZMGHhGLgQrjvPWzPJgJvzStbbq\r\nLGNLLNBBzcDFCBwwFC\r\nnJTTqnrNvTzNMzzNfqrTPrJnwpwPpZpsHccZVsBRpcVHwpcp\r\nbgDhgbghLWmFmStctVpZtBCVCCpfZp\r\nLLSgLGSjggFGbSSbmMnrvqvzjfzTNrJrqM\r\nRRpDmmPMTjwfGmJQgQ\r\nWsNscdnvvdVZFVnnrZbjjflwljlbzfGFjQjq\r\nNnLZsNnrrVVVcvdBLTPCPCRMwhPMBMPhCt\r\nlbVvzngGJnVbJHpHtHNPpdSQvc\r\nTsMBswFZsWMWBZMNwPtNNtRNHcNpSQ\r\nCcZCTrZDsjZTsTsshWhrWrTnfgbLDfJzVVLVVlgfnzfVGV\r\nJzTTRtJRZWmWjrMHCT\r\nDDFGlLGcGlSSSLsFGBspPBmNMBHMghmWNmWjWCmWtH\r\nnSSpnbsGlLDnpPsSSspFtVvffRQdVzqvvbqdfVQwRz\r\nsMhzszlHHDsWbthHDqsbJjpLNtmjVJmVLLVLVLBp\r\nnrTPrGwfPLdprzJzdL\r\nwgPQcTGGzgccwCgnRwgRChFhlWSDqWWQMWhssSsMQl\r\nNSNmwtpSpCpvMphCsr\r\nPHcRGPLJMrsvzsqG\r\nQHjbnRMcfbPbQZmlZgZlgBBQ\r\ncPRPbhQjbQRdtPQdLqLHqzFZjCFCqLjC\r\nmmfsnnwrfvwrfSNZFzHHLDCFNlLlqDlN\r\nwsmrwswwGTffMrBnmQttJtcMZQQtPJPbZc\r\nMvBPDDRRdnnvHPCHZLHZsFLL\r\nrmJcbVqbcjWwWjQHLzTZFTHSzFrpsz\r\ncmwllVqqGJbVVVmmqbQcmgRnRvGhGfgDRDZBBBvRdd\r\nnMvMhMnvhnbTZWSSZgHmGJDFmmNDzBmbNmdGBN\r\nrCsPLRCssRjrLLsrLlwRVrcNJQfDQfdBmmfNBGJNzmDPfB\r\nCRjCpLltgtJgJJWq\r\njshCzJpjzTPpmCWvSlpfwHfSWglf\r\nLQMMNMnHtDtLVRvwwgRWlldgWD\r\nqHVrQNHVMFQtrrBBQMBcrrZsZbzCZhbbJZJsmmsmFPTC\r\nJZQZnsQNMqTngZqJBVfBfPPVBNrwvfPw\r\nSSmDstFjpDpCszDjcLLhrPVlGlrGGVBwrvwVPt\r\nFSssFcLjFjbmFFCzjLcFLRDnMJnTHRnZZTdWqZZWnMnRnZ\r\nGbHRHpldwGMpWhHpCMBlCbRdVSLhnqJLSrDPLPPLPDqVDrhh\r\ngvjWWQvgZFtQFFNqLnVnDnSJzzztDD\r\nZccccfTsffHdWWdRWwsw\r\nClCtbHMlnnPPlszV\r\ngSDWSLgWQWQJJNWqgtQjPsnfcdVcLVdVdzfzVzff\r\nWQgqtFQgDgQSFqJhqhSJvNDRrZMZHwHMCbZhTpZbGHMTMG\r\npZJZlCQtHFhPfdNfCh\r\nzcmLSVczwcMcLDNFHdLPhPWH\r\nszvVVnBmnTGQtHTQ\r\nRVVCNDlNGzlGZqHGHWqWhGqQwH\r\nZFLFTmpLvvmSqsbb\r\nTrfpBfJpJMlnnNfNZD\r\nqHHlDClHhltMqQsHDhHslGznwdTnzzwDGSdfnwGnwG\r\nmZRNcNcLLPNPBFFbbPmLmbZFSCVfJJTVndVfSwnRzznfTwCS\r\nCcCWFbbBLCWtgWgHjghqvv\r\nTjbzlnlFmfqCFFVVCRWr\r\nPhMcLpPDtMLpwPDvLPJbMhSgVCGqggVqQgCqCgCgSWvv\r\nbtbZbNZhJDJJhDtwtsTTTmBzzBBmlNlmHj\r\nFqhjWtqlqmmsnFPTCvMCQMTTCjQd\r\npfffRfLpgrgGgzrNVzzpGVzRCdMCPJbwwcVMbQPCJVMVdbww\r\nDGGDZRGrHggzSsFQnnWShmtH\r\nvtHVVMMrvVMVrSHvLgvlHcZFCnRCZcccZtRRZfJFCJ\r\nrdDjGsdTQDcNZfdncCRR\r\nrBDsTwBbjbmbbQswswPhqVmmSvpVhlvvqMhHhh\r\nvGBLrqMNvqSLBvvrNbllLHfwStWWtFttccjtRtjtcj\r\nMhCDJmhMDzmcRRcjzWfztH\r\nZQDmDhVVCQbBVdVNMvvv\r\nptCtCzhWPWptnhVzzpGZbZTjTjVjFGjVFgVl\r\nfQswRRffmRqZlgrqqFjjSgGg\r\nHwsQDNNsDsmRLLHmffsfvHptBnhtzCvhWpZWBdhnMdCh\r\nRlHzzTqczBPfbnvcpB\r\nwVtNwpSZstppwwMsZhsdnLvnbtBBmbnLFFdnmF\r\nWNQJMVWsZWwGJWhhSNrQzlgHrDCgQRHpCHrl\r\nRrZWpJZRrZpdTGstlchLGGlLMd\r\nNqjDPCQPnQCSvtMzSLhhjM\r\nnQVQDDDDfwBwNCVCNVFNpWpgJgrRTmLTmTmgRTWF\r\nSHMcrMHpcjGcjSrMMbvSvvSvwFTLJwJNtFGFWJNtDLFTLfWN\r\nzqRnPfzQCRzqsmRPzznhszzLtLwQwwFTgWWLDLgWFTwTNQ\r\nqVPZmRZhsCZPhZlRCqRRRCbfpccMBjvMVjdHjjMjSvdf\r\nVVQdHwBZLVltlddtBczhrzvGcWWFRwgsFG\r\nTDTTTqqTSSqjqnmTmPqPPmTmGhRszvsrzsjRsccgzrRzgWGF\r\nDpJPqpWqHbZpllpt\r\ncCSCFsnnZFnscDtNdJFJtJtdmb\r\nVgBqBsqRrHtNdzmNrt\r\nBGLLVVjRBsqPBfsGwPsMfSSZCSfTZTZQpSphfS\r\nplCHCHlgglHHGpNbtngNrDvBDpfQDBQfZDfWZVrr\r\nmTmMLhRfwhsLPQvQZDMZQBQWMB\r\ncwsssmqRTFFfFgtbCtGl\r\nLQPPrCPnMZwqtRMn\r\ncWTSlJWlcplJdDTdGdpDlGcGgqmtwwZtqRrNRRmRdNZqmgNq\r\nGSJcJSjsjTpsvWGWBHLLvVVBBBrFrzVz\r\nNVPCSPMNDSNFVSWCsJJJmpGmZZGLLcpZLHGGtsHt\r\nfwzlBBqghqvzqqlDrHbpHjZHmGZbLZrHLb\r\ndnBgnDqQvwRnSnnFMFMP\r\nBCbPsFFwCRHmDSBmWnvDDj\r\nphhZVzdpVfQZphhZpRhSVnjmrcvvnrWtDrvWDS\r\nTfQJMfLphMhJdfdzpQJRTPbwHHNlgbGwsTGgCP\r\nttWLlnnvnNnBBtlTqWlpvpndQdZsQQFssFDdsRFdVdRNFQ\r\njSgrScrbGZSGrrCGsFVMssFsPPFcDDMV\r\nbzSmJbfCZCbzLwllflwqtvvw\r\nzmFTJwFLPmzLztmjDzTJwfNrdFNrFppBSNRGNGdbrpBR\r\ngqlhWQgsZMsvqMlMMvsvqsNlLbcdppbrRpdbbcSrrbbr\r\nvssCgVgCsggZQZCgsnsqWgWvfJPDLwffwTPPmzTnjTPmPmwJ\r\nSpcRTPQLBLWpNNzjmmwwwRrR\r\ntGlfvGhfnbDlbqlChnfFMrwsmwNssTMHMHjFwv\r\nZlhtCtffCdWcZWZVVT\r\njTTCcWHWJNgCGTzTmnzrmnGn\r\nBwRRbFvtvvQmJJFMpMJr\r\nZBBwLvqbBZsRsbVsZSqbcZdJjHHjhfPCJfJfHhgc\r\nVrnDSvvrLrfTdTLGfdRp\r\nzcJzmcFcHGfdGmWTVd\r\ntHsMhwPVctccHFHFcbSDbbPjnNbBnbvBQB\r\nQttWQwLTnLnWTtnffnLQSBFVjNvBjBFNgMdCsVWsjv\r\npDqcmmRPHqgVBddjvN\r\nDcclzbcbPbJLnNTfnw\r\nplRcpsZDGlGZvWvMCNcLtttq\r\nSrfrwSjSVrSjwbmSrHzmHJCQQPQzqttNNQJMzJtqMW\r\nwSHVnfHfWwwHWFVfSnfgmmRsslFZZDBBGZsZsDTdGRTp\r\nqSFQSgQNgQBrBHHcrW\r\nVTmjVJLTwlTmwTVmsMJMVlJmPvcbvvbCBbGBPjGvBbBGWcbb\r\nDnJTZwmnZRhnpqNdWt\r\ndTVHjZLLZDVCfVHtLDDjQbscjWbSJMJPjsbWWb\r\nFnqrnmzzFllmsWwtsFtQMMFc\r\nlmqzzzngGmlNNBqGllzlBNRvptHHpTCHpDLpgDZdgvHvDD\r\nsdRZQbCfZTSTdlfTZCffccWPHPPcPPwLwctRnLWn\r\nBBJDzFVgCDrCJrqDJJhqJVVMLPHwcctFwcWHHGLcwGwGHnWc\r\nghpJgqqjCZbQdZpd\r\ntbcpzbHSszcHBgqHGZgJJJhhww\r\njfvdvRTffQQrrFCRFTnGwJRqNRZVpJGZLZggLh\r\nnQTjTnMndlTdQFMvnrClCnpzmzDtbbmBbcPSzzlmmtzP\r\nBqBqTCSTcqHsJHHM\r\nWWPGVPLtzVgWtjWPGzVjzVGcbDhPsRbDcsbJwNRswRDRss\r\nVQfWjfLFGWLjdFfVzTZZpJTpnmlTrSQlBl\r\njLNsZjqSHCsGdsmpsm\r\nMvnVFzWMwMVWzfnVDwfBMfnnrCtdtPmPlRrdrJCJrtPDrrPD\r\nzznfFWwMfMfFMwVTMQFnQjhjgjSZhCNbLSTcHHgbbC\r\nGGtssttVmvnnGNMQrrVzgwVrCWMz\r\nFdhfhhcCDhHLfzclZMcrwcQMZM\r\nHHqqCBhHSSpdmjGqmGjtjtjj\r\nbbQLtGMQQtQRQtrDtGprrrbCqwplZhhqSqmdwvdzqqqhSmpS\r\nFsJjJBfnsJcFcFfjVPjWBzldqhqnlZZZzzhmnSvSnm\r\nJPcFfFWjFHJVVsVjPVscsDlLNRHGDbLRMRCDNrCGbG\r\nJdMdlMRJnTwdvcjv\r\nCDLHbNSzzLFgHvnTjrswBNBTNT\r\nQgbvzSFQmZQPQQRW\r\nNTBrNzrpjjjCwGbB\r\nFRbQlcvFvcRQQlRsMlRRRZjwCqMwjmjwJZdLJmjCZC\r\ncVPPQcvlWDNhrbPz\r\nVdbVtbbZJdtJVVdDVZmTLqqTSQvNLjjDShhvSG\r\nzplpnBnFpnrrlghGNpLNqHvqvjNj\r\ncWncllnlPFWzcMwtWWtsVLVRmJWCds\r\nShLSTnZnTSttTSbLQdfSZTMwcDHwwcHnJvDHnlnlclMM\r\nNmPMsssRrVwjDclHJwwR\r\ngNNMWGzNmqGdtfZTbGGb\r\nsWNNlRHnmJtmntJt\r\nbrbbBTbbFbCbqqGgBTrCfmQVVZfSSQQSVtJZSrVZ\r\nbbFqvbDvvGGLGbCCtBGDLbLlcPNHhhccPNcdPPchlsdR\r\nDCFvDvnCnNfMBmMMslDZML\r\nSQQQJHwpSgJSJHQWSWHqJWWbmcBBBLLTsmhhTcZbMhmlshcb\r\nRJRgpJHssgwSQHRqsQPGGjjtNCrrFvvnFjjPrP\r\nmThmsgjzTPjMpcvtWP\r\nGNNBVqVGNZbbNbNqqZQVNVNbWcpdtMCcpCtMWCdCPpQccmpp\r\nVSmNrmmbBfZVlsrssrLTRhRhTn\r\nTdmCvLDCpTRNTdFbbWnnSWCfhjbbzn\r\nGrrMsPVGcQHBGMbhjjSgWfHHDbjb\r\nBPBVqqrQPsQqwrrmmmJdRLDDqFRplT\r\nfpDDJljDlCfDTjprjrfbddWthCSCtdPPQFhSSSWW\r\nHsLZgMGbgBBsNzMvGbdVtVQzFRQSthhFPdtP\r\nsMBmGBmbNvLHGMnrDppTcJmcjpqljf\r\nptSpSJQqpbNGGDDhcMWrlNHcZZWWls\r\nzRLRRRjvvgjHMMsMpWpc\r\nvmCPLCgwvwdnCzmvLbpTbVQqJJPbJPpTVq\r\nTJCfhhJVFffrJJQQllNWcvWhwvWD\r\nGPSGjjpLslBbpLpLqqqPDvdwvwvNzQWGzDDNdzGN\r\nmsbRjbpPqsRpHnlZrmJlnVHT\r\nGGfFsCCTvGDsfTTrhsCMMzptZJMdpdgtrpdMcV\r\nLBlwBHPSqjwwlVggHpnMZcVHMt\r\nZlZZlBbRPGGTGfmRsD\r\nCtCjbVvzQQZTWVdd\r\nMlSqWlmsmGBSHJHTDFHZ\r\npcqsmsplwsqclwRtRWgtRnPPvb\r\nzCrzCrsdjrhGDCFqGDjRRPtpWfQQcpfQZcCZPp\r\nVSVwVMgLHHLTwMDTMMVnbWPRZQRcRQPptWnpbZcb\r\nMNBBBlSMvLVwTlVTFdNdhNhFsqsGDrzm\r\nrBLWTwTThWwVVDTwHBsZZWppvpGtpptppmRvFFFMFMfL\r\nqPPNCCbqcbcNqbqQjjJQqzjRpptmlpMGmMlJtftmtFHpMt\r\nQnCgzzQbbQqPcPQnncbdQdnVTwDssZgrShBTVgZZsBSDHT\r\nPFGJFqnfqmPgFJQPWdbLdpDRhbphWjDm\r\nrclNHvcrzCNwrWRprjdMMMph\r\nwsZHwZNvRRQsQqBV\r\nLqlGCPlPLTCPqqQlpqLlWfBfWgcHNRJRfWNsncGH\r\nVVtdwVtDDdVmhrdwSBmjbdzNHgfgJnNnsSnHsNffHgRsgR\r\nwVzhbjmDbDrwjdbztFDDthMCvqPppZQBQLZQTqTvFTvZ\r\nBnQnQFwRmRwmwdBSFDFnmSDVLCJTCTppVVmGLVTCLcgVpC\r\nZlWvhvZjNrbNvqjNhlfPfqjCGHrsspggTpVLpsJCpcJVgg\r\nvPzNvqjWhqFzGSnRGMDG\r\nwZnMZzzZZchDRtVsqtCtwV\r\nWmWpWWmPPWrmrmBmWrTlTFPNVqVCRSDCQHcqVTtTqsSDSTSD\r\nPrppdFlWWlfrWmpWFffrdcGjJJGggnnhZGdLLgGGndvz\r\nFShHNmNhRhNJmBnQBQJrmP\r\nVTgzDTjwfffwzDvwlcczzVSJbQlBQSWBWCnPJPbJWWbC\r\ntzSVtzvSvGSRZqqFMNtpRR\r\nhPZhGDZpnCGtDhznjmLmdJffdNzJ\r\nglwsSrQwBvLdgLzdcj\r\nQsRbHllzzlHwHlBszWlTBFbpDPMhbPDVGpGFpPtFPp\r\nSRjStRDctgDSBzLvPvNrDhmPLr\r\nQqTHGTPJmmHmhNmH\r\nTGQZsTqFnQZCJTPsnJnZQMjVRBVtcVRSVRBlwccSCtBS\r\nbbsNsvsvnNPTRRllbblLqhtQCqQSLCGGHSqHNC\r\nwFpzFgqVzqVJWFDwqJDmSBBmHBHhShLQhCGSBCGH\r\nMJVpFMqgwMqRRbZsMbZMrP\r\nPPdDhvNDQdmgQPZmQVHHtHGGWVGbffWGvs\r\nMMLCTRRLlLclTLRMRLCwMLHWVctbVVHWWWFfVjVGsFWW\r\nMRSMMlpTJRqClBCRqBDnzqgQPnqgznZPZqbP\r\nMrMNPNNpjvdprWtrpMsthqBfqlnfqcGhVBqFRcnqFG\r\nQbDgSSQbgSDDmDVmlqSCRllRcFqnqfBl\r\nQVJbVmwwDQbzVTgbppNJNMWNjNNPrdpM\r\nWwJJNbtHfpLpVgZZPVFhZh\r\nvmmqlDvRvRfqBSrlzmmMjRBhcVhQVZhVghCQQQQTcTrPTP\r\njSqMmqRzMDDjvqlBqsBMBmmwGNJwJnwLNfbGwddswnJtJH\r\nRLgRmRggbvbzzPmmRNmzsQWFtSGNtwSNQnntFwnnCw\r\npDBrBHpHhlldphHBHhJVFSLnWWFJttCtQSttSS\r\nhfHrpphHBppfTvmzgMmbLbgf";
        static void Main(string[] args)
        {
            string[] rucksacks = input.Split("\r\n");
            int sum = 0;
            int groupCount = 3;

            Elves[] elfGroupList = new Elves[rucksacks.Length / groupCount];


            for (int i = 0; i < elfGroupList.Length; i++)
            {
                Rucksack[] rs = new Rucksack[groupCount];
                for (int j = 0; j < groupCount; j++)
                {
                    int rucksackIdx = j + i * groupCount;
                    int middle = rucksacks[rucksackIdx].Length / 2;
                    rs[j] = new Rucksack
                    {
                        Lcompartment = rucksacks[rucksackIdx][0..middle],
                        Rcompartment = rucksacks[rucksackIdx][middle..rucksacks[rucksackIdx].Length]
                    };
                }
                elfGroupList[i] = new Elves(rs);
                Console.WriteLine(elfGroupList[i].r1);
                Console.WriteLine(elfGroupList[i].r2);
                Console.WriteLine(elfGroupList[i].r3);

                Console.WriteLine(elfGroupList[i].FindBadge() + " - Value of badge = "  +Cnvrt.CharToNumber(elfGroupList[i].FindBadge()));
                sum += Cnvrt.CharToNumber(elfGroupList[i].FindBadge());
            }
            Console.WriteLine(sum);
        }

        private class Elves
        {
            public Rucksack[] rucksacks = new Rucksack[3];
            public string r1, r2, r3;

            public Elves(Rucksack[] rucksacks)
            {
                this.rucksacks = rucksacks;
                r1 = rucksacks[0].Lcompartment + rucksacks[0].Rcompartment;
                r2 = rucksacks[1].Lcompartment + rucksacks[1].Rcompartment;
                r3 = rucksacks[2].Lcompartment + rucksacks[2].Rcompartment;
            }
            public char FindBadge() => r2.Intersect(r3).Intersect(r1).First();
        }

        private class Rucksack
        {
            public string Lcompartment;
            public string Rcompartment;

            public char FindSameCharInCompartments() => Lcompartment.Intersect(Rcompartment).First();
        }

        private static class Cnvrt
        {
            private static string charList = string.Join("", Enumerable.Range('a', 26).Select(i => (char)i)) + string.Join("", Enumerable.Range('A', 26).Select(i => (char)i));
            private static int[] numberList = Enumerable.Range(1, 53).Select(i => i).ToArray();
            public static int CharToNumber(char value) =>  numberList[charList.IndexOf(value)];
        }
    }
}