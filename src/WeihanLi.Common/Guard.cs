﻿using System;
using System.Runtime.CompilerServices;


/* Unmerged change from project 'WeihanLi.Common(net6.0)'
Before:
namespace WeihanLi.Common
{
    public static class Guard
    {
        public static T NotNull<T>(T? t,
               [CallerArgumentExpression("t")]
            string? paramName = default)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(t, paramName);
#else
            if (t is null)
            {
                throw new ArgumentNullException(paramName);
            }
#endif
            return t;
        }

        public static string NotNullOrEmpty(string? str,
            [CallerArgumentExpression("str")]
            string? paramName = default)
        {
            NotNull(str, paramName);
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("The argument is IsNullOrEmpty", paramName);
            }
            return str!;
        }
After:
namespace WeihanLi.Common;

public static class Guard
{
    public static T NotNull<T>(T? t,
           [CallerArgumentExpression("t")]
            string? paramName = default)
    {
#if NET6_0_OR_GREATER
        ArgumentNullException.ThrowIfNull(t, paramName);
#else
            if (t is null)
            {
                throw new ArgumentNullException(paramName);
            }
#endif
        return t;
    }

    public static string NotNullOrEmpty(string? str,
        [CallerArgumentExpression("str")]
            string? paramName = default)
    {
        NotNull(str, paramName);
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentException("The argument is IsNullOrEmpty", paramName);
        }
        return str!;
*/
namespace WeihanLi.Common;

public static class Guard
{
    public static T NotNull<T>(T? t,
           [CallerArgumentExpression("t")]
            string? paramName = default)
    {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(t, paramName);
#else
        if (t is null)
        {
            throw new ArgumentNullException(paramName);
        }
#endif
        return t;
    }

    public static string NotNullOrEmpty(string? str,
        [CallerArgumentExpression("str")]
            string? paramName = default)
    {
        NotNull(str, paramName);
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentException("The argument is IsNullOrEmpty", paramName);
        }
        return str!;
    }
}
