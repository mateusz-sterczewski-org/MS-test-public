using System.Security.Cryptography;

class A {
    private void foo() {
        using (var s = SHA1.Create()) {
            s.ComputeHash(user.password);
            // bearer:expected csharp_lang_weak_hash_sha1
            s.ComputeHash(user.email);
			s.ComputeHash(user.email);

        }
    }
    private void obseleteShaManaged() {
        sha = new SHA1Managed();
        sha.ComputeHash(user.password);
        // bearer:expected csharp_lang_weak_hash_sha1
        var data = sha.ComputeHash(user.email);
		var hashPart64 = BitConverter.ToUInt64(data, 0); // don't trigger on this
    }
}
