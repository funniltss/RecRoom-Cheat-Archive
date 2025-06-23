using System;

namespace Nerec.Library.Critical.ClientAuth
{
	// Token: 0x0200018D RID: 397
	public sealed class ACKDMFFONHEGBBJLKK : HMLHHOLDAFJBNAKPPD
	{
		// Token: 0x060006BC RID: 1724 RVA: 0x00006892 File Offset: 0x00004A92
		public void GenerateChallenge(byte[] serverChallenge, byte[] clientResponse)
		{
			if (!ACKDMFFONHEGBBJLKK.CanDecryptBase64String(BitConverter.ToString(serverChallenge).Replace("-", "")))
			{
				throw new InvalidOperationException("Cannot generate challenge because the 'serverChallenge' is invalid.");
			}
			clientResponse = ACKDMFFONHEGBBJLKK.GenerateRandom(serverChallenge.Length);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001A79C File Offset: 0x0001899C
		private static byte[] GenerateRandom(int count)
		{
			Random random = new Random();
			byte[] array = new byte[count];
			random.NextBytes(array);
			return array;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001A7BC File Offset: 0x000189BC
		private static bool CanDecryptBase64String(string base64String)
		{
			bool result;
			try
			{
				Convert.FromBase64String(base64String);
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}
	}
}
