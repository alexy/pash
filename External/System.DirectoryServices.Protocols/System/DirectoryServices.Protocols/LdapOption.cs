namespace System.DirectoryServices.Protocols
{
	internal enum LdapOption
	{
		LDAP_OPT_DESC = 1,
		LDAP_OPT_DEREF = 2,
		LDAP_OPT_SIZELIMIT = 3,
		LDAP_OPT_TIMELIMIT = 4,
		LDAP_OPT_REFERRALS = 8,
		LDAP_OPT_RESTART = 9,
		LDAP_OPT_SSL = 10,
		LDAP_OPT_REFERRAL_HOP_LIMIT = 16,
		LDAP_OPT_VERSION = 17,
		LDAP_OPT_API_FEATURE_INFO = 21,
		LDAP_OPT_HOST_NAME = 48,
		LDAP_OPT_ERROR_NUMBER = 49,
		LDAP_OPT_ERROR_STRING = 50,
		LDAP_OPT_SERVER_ERROR = 51,
		LDAP_OPT_SERVER_EXT_ERROR = 52,
		LDAP_OPT_PING_KEEP_ALIVE = 54,
		LDAP_OPT_PING_WAIT_TIME = 55,
		LDAP_OPT_PING_LIMIT = 56,
		LDAP_OPT_DNSDOMAIN_NAME = 59,
		LDAP_OPT_GETDSNAME_FLAGS = 61,
		LDAP_OPT_HOST_REACHABLE = 62,
		LDAP_OPT_PROMPT_CREDENTIALS = 63,
		LDAP_OPT_TCP_KEEPALIVE = 64,
		LDAP_OPT_FAST_CONCURRENT_BIND = 65,
		LDAP_OPT_SEND_TIMEOUT = 66,
		LDAP_OPT_REFERRAL_CALLBACK = 112,
		LDAP_OPT_CLIENT_CERTIFICATE = 128,
		LDAP_OPT_SERVER_CERTIFICATE = 129,
		LDAP_OPT_AUTO_RECONNECT = 145,
		LDAP_OPT_SSPI_FLAGS = 146,
		LDAP_OPT_SSL_INFO = 147,
		LDAP_OPT_SIGN = 149,
		LDAP_OPT_ENCRYPT = 150,
		LDAP_OPT_SASL_METHOD = 151,
		LDAP_OPT_AREC_EXCLUSIVE = 152,
		LDAP_OPT_SECURITY_CONTEXT = 153,
		LDAP_OPT_ROOTDSE_CACHE = 154
	}
}