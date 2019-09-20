using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;


public class GetERC20Balance : MonoBehaviour
{
    public Text tokenBalanceText;

    // Start is called before the first frame update
    async Task Start()
    {
        var balance = await BalanceOfERC20();
        Debug.Log($"I have {balance} Wei TEST Tokens");
        tokenBalanceText = GetComponent<Text>();
        tokenBalanceText.text = balance.ToString() + " Wei";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static async Task<System.Numerics.BigInteger> BalanceOfERC20()
    {
        var matic = Settings.GetMatic();
        return await matic.BalanceOfERC20(Settings.FROM_ADDRESS, Settings.MATIC_TEST_TOKEN);
    }
}
